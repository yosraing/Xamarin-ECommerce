using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAp.ViewModels
{
    public class MainViewModel
    {
        #region Properties

        public ObservableCollection<MenuItemViewModels> Menu { get; set; }

        #endregion

       #region Constructors  

        public MainViewModel()
        {
           Menu = new ObservableCollection<MenuItemViewModels>();
            LoadMenu();
        }

        #endregion

        #region Methods

        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModels
            {
                Icon = "ic_action_product.png",
                PageName = "ProductsPage",
                Titre = "Productos",
            });

            Menu.Add(new MenuItemViewModels
            {
                Icon = "ic_action_customer.png",
                PageName = "CustormersPage",
                Titre = "Clientes",
            });

            Menu.Add(new MenuItemViewModels
            {
                Icon = "ic_action_order.png",
                PageName = "OrdersPage",
                Titre = "Pedidos",
            });

            Menu.Add(new MenuItemViewModels
            {
                Icon = "ic_action_delivery.png",
                PageName = "DeliveriesPage",
                Titre = "Entregas",
            });

            Menu.Add(new MenuItemViewModels
            {
                Icon = "ic_action_sync.png",
                PageName = "SyncsPage",
                Titre = "sincronizar",
            });

            Menu.Add(new MenuItemViewModels
            {
                Icon = "ic_action_setup.png",
                PageName = "SetupPage",
                Titre = "Configuration",
            });

            Menu.Add(new MenuItemViewModels
            {
                Icon = "ic_action_logut.png",
                PageName = "LogutPage",
                Titre = "Salir",
            });

        }

        #endregion
    }
}
