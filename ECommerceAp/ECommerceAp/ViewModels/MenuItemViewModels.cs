using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ECommerceAp.Services;
using GalaSoft.MvvmLight.Command;

namespace ECommerceAp.ViewModels
{
    public class MenuItemViewModels
    {
        #region Attributes
        private NavigationService navigationService;
        #endregion

        #region Properties
        public string Icon { get; set; }

        public string Titre { get; set; }

        public string PageName { get; set; }

        #endregion

        #region Constucteurs
        public MenuItemViewModels()
        {
            navigationService = new NavigationService();
        }
        #endregion

        #region Commands
        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); }  }

        private async void Navigate()
        {
            await navigationService.Navigate(PageName);
        }
        #endregion
    }
}
