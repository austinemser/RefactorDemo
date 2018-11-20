using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using RefactorDemo.Interfaces;
using RefactorDemo.Services.Order;
using RefactorDemo.ViewModels;
using Xamarin.Forms;

namespace RefactorDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var orderService = FreshIOC.Container.Resolve<IOrderService>();
            var settingsService = FreshIOC.Container.Resolve<ISettingsService>();
            var viewModel = new MainPageViewModel(settingsService, orderService);
            BindingContext = viewModel;
        }
    }
}
