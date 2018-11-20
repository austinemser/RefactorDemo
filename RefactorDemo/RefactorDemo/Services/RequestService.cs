using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RefactorDemo.Interfaces;
using Xamarin.Forms;

namespace RefactorDemo.Services
{
    public class RequestService : IRequestService
    {
        public async Task<T> GetAsync<T>(string url, string token)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    //client.DefaultRequestHeaders.Add("Api-Version", DependencyService.Get<IAppVersionProvider>().AppVersion);

                    var responseString = await client.GetStringAsync(url);

                    return JsonConvert.DeserializeObject<T>(responseString);
                }
            }
            catch (Exception ex)
            {
                //Crashes.TrackError(ex);
                return default(T);
            }
        }
    }
}
