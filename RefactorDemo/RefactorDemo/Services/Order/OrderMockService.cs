using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefactorDemo.Extensions;

namespace RefactorDemo.Services.Order
{
    public class OrderMockService : IOrderService
    {
        private readonly List<Models.Order> _mockOrders = new List<Models.Order>
        {
            new Models.Order {TransfereeName = "Bob Dole"},
            new Models.Order {TransfereeName = "King James"}
        };


        public async Task<ObservableCollection<Models.Order>> GetOrdersAsync(string token)
        {
            await Task.Delay(5);

            return _mockOrders.ToObservableCollection();
        }
    }
}
