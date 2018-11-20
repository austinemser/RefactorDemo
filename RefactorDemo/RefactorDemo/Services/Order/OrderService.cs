using System.Collections.ObjectModel;
using System.Threading.Tasks;
using RefactorDemo.Interfaces;
using RefactorDemo.Models;

namespace RefactorDemo.Services.Order
{
    public class OrderService : IOrderService
    {
        //Gets Depedency Injected.
        private readonly IRequestService _requestService;

        public OrderService(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public async Task<ObservableCollection<Models.Order>> GetOrdersAsync(string token)
        {
            var uri =
                "//TODO: UriHelper.CombineUri(GlobalSetting.Instance.OdinOrderEndPoint, MobileDestinationBaseUri)";

            return await _requestService.GetAsync<ObservableCollection<Models.Order>>(uri, token);
        }
    }
}
