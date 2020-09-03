using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts_App_
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Valgusfoor2();//  Стартовая и единственная страница MainPage()
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
