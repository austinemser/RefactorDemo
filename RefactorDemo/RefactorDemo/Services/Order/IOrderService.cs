using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace RefactorDemo.Services.Order
{
    public interface IOrderService
    {
        Task<ObservableCollection<Models.Order>> GetOrdersAsync(string token);
    }
}
