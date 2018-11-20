using System;
using FreshMvvm;
using RefactorDemo.Interfaces;
using RefactorDemo.Services;
using RefactorDemo.Services.Order;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace RefactorDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitApp();
            MainPage = new MainPage();
        }

        private void InitApp()
        {
            
            FreshIOC.Container.Register<ISettingsService, SettingsService>();

            //TODO: Find elegant way to determine if we are testing or not.
            var isTesting = false;
            if (!isTesting)
            {
                FreshIOC.Container.Register<IRequestService, RequestService>().AsMultiInstance();
                FreshIOC.Container.Register<IOrderService, OrderService>().AsMultiInstance();
                
            }
            else
            {
                FreshIOC.Container.Register<IRequestService, RequestService>().AsMultiInstance();
                FreshIOC.Container.Register<IOrderService, OrderMockService>().AsMultiInstance();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
