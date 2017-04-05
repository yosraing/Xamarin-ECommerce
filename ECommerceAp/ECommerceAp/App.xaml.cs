using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceAp.Pages;
using Xamarin.Forms;

namespace ECommerceAp
{
    public partial class App : Application
    {
        #region  Propriétes
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }
        #endregion

        #region Constructeur
        public App()
        {
            InitializeComponent();
            MainPage = new MasterPage();
        }
        #endregion

        #region Methodes
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
        #endregion

    }
}
