using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EPosDemoMvvm.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EPosDemoMvvm.Core.ViewModels.Sale
{
    public class SaleViewModel:MvxViewModel
    {
        private IMvxNavigationService _navigateService;
        private OrderViewModel order;
        public SaleViewModel(IMvxNavigationService navigationService) {

            _navigateService= navigationService;
            AddOrderCommand = new MvxCommand<ProductItemViewModel>(AddToCart);
        }

        private void AddToCart(ProductItemViewModel obj)
        {
            order.GetCartCommand.Execute(obj);
            
        }

        public async Task navigate()
        {
            var product = new ProductViewModel(_navigateService) { AddProductToCartCommand =AddOrderCommand };
            await _navigateService.Navigate(product);
            order = new OrderViewModel(_navigateService) ;
            await _navigateService.Navigate(order);
        }

        public override Task Initialize() => base.Initialize();

        public MvxCommand<ProductItemViewModel> AddOrderCommand { get; set; }
  


    }
}
