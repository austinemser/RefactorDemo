using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RefactorDemo.Interfaces
{
    public interface IRequestService
    {
        Task<T> GetAsync<T>(string url, string token);
    }
}
