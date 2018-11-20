using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RefactorDemo.Interfaces;
using RefactorDemo.Services.Order;

namespace RefactorDemo.ViewModels
{
    public class MainPageViewModel
    {
        private readonly ISettingsService _settingsService;
        private readonly IOrderService _orderService;

        public MainPageViewModel(ISettingsService settingsService, IOrderService orderService)
        {
            _settingsService = settingsService;
            _orderService = orderService;
        }

        async Task PopulateOrders()
        {
            var orders = await _orderService.GetOrdersAsync("Fake token");
        }
    }
}
