using System;
using System.Collections.Generic;
using System.Text;
using EPosDemoMvvm.Core.Services;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace EPosDemoMvvm.Core.ViewModels.Sale
{
    public class ProductViewModel:MvxViewModel
    {
  
        private IMvxNavigationService _navigateService;
        public ProductViewModel(IMvxNavigationService navigationService)
        {


           _navigateService= navigationService;
            AddProductCommand= new MvxCommand<ProductItemViewModel>(AddOrderItem);
            for (var i = 1; i <= 8; i++)
            {
                var price=new Random().NextDouble();
                var color= string.Format("#{0:X6}", new Random().Next(0x1000000));
                Products.Add(new ProductItemViewModel { Product = new Product(i, "name " + i, price*10, $"https://dummyimage.com/250/" + color) });
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();
           
        }


        public MvxCommand<ProductItemViewModel> AddProductCommand { get; set; }

       
        public MvxCommand<ProductItemViewModel> AddProductToCartCommand { get; set; }
        

        private void AddOrderItem(ProductItemViewModel item)
        {
            
            AddProductToCartCommand.Execute(item);

        }

        private string imgUrl = "https://source.unsplash.com/random/200x200?sig=";


        private List<ProductItemViewModel> _products = new List<ProductItemViewModel>();
        public List<ProductItemViewModel> Products
        {
            get => _products;
            set
            {
                SetProperty(ref _products, value);
            }
        }
    }
}
