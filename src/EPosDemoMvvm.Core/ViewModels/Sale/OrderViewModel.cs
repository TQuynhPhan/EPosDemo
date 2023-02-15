using System;
using System.Collections.Generic;
using System.Text;
using EPosDemoMvvm.Core.Services;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Commands;
using System.Linq;
using System.Collections.Specialized;
using System.Diagnostics;
using System.ComponentModel;

namespace EPosDemoMvvm.Core.ViewModels.Sale
{
    public class OrderViewModel:MvxViewModel
    {
        private IMvxNavigationService _navigateService;

        public OrderViewModel(IMvxNavigationService navigateService)
        {

            Orders = new MvxObservableCollection<OrderItemViewModel>();
            PayCartCommand = new MvxAsyncCommand(ShowDialog);

            GetCartCommand = new MvxCommand<ProductItemViewModel>(AddProductsCart);
            _navigateService = navigateService;


        }



        private async Task ShowDialog()
        {
            var request = new YesNoQuestion
            {
                YesNoCallback = async(yes)=>{
                    if (yes)
                    {
                        PayCart();
                    }
                },
                Question="Do you want to pay this cart?"
               
            };
            _interaction.Raise(request);
        }

        private void PayCart() {
            Orders.Clear();
            SubTotal = 0;
            TotalQuantity = 0;
            Pay = 0;
            EmptyOrderVisibility = true;
            RecyclerViewVisibility=false;
            _navigateService.Navigate<PaymentViewModel>();
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            CalcSubtotal();
            CalcTotalQuantity();
            CalcPayment();
        }


        private MvxObservableCollection<OrderItemViewModel> _orders;

        public MvxObservableCollection<OrderItemViewModel> Orders
        {
            get => _orders;
            set
            {
                SetProperty(ref _orders, value);
                CheckEmptyOrderVisibility();
                CheckRecylerViewVisibility();
                CalcTotalQuantity();
                CalcSubtotal();
                CalcPayment();
              
            }

        }

        public IMvxAsyncCommand PayCartCommand { get; set; }

        private MvxInteraction<YesNoQuestion> _interaction = new MvxInteraction<YesNoQuestion>();

        public IMvxInteraction<YesNoQuestion> Interaction => _interaction;

        private bool _recyclerViewVisibility;
        public bool RecyclerViewVisibility
        {
            get=> _recyclerViewVisibility;
            set
            {
                SetProperty(ref _recyclerViewVisibility, value);
            }
        }

        private bool _emptyOrderVisibility;
        public bool EmptyOrderVisibility
        {
            get => _emptyOrderVisibility;
            set
            {
                SetProperty(ref _emptyOrderVisibility, value);
            }
        }

        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                SetProperty(ref _subTotal, value);
            }
        }

        private int _totalQuantity;
        public int TotalQuantity
        {
            get => _totalQuantity;
            set
            {
                SetProperty(ref _totalQuantity, value);
            }
        }

        private double _pay;
        public double Pay
        {
            get => _pay;
            set
            {
                SetProperty(ref _pay, value);
            }
        }

      
        private void CheckRecylerViewVisibility()
        {
            RecyclerViewVisibility = (Orders.Count > 0);
        }

        private void CheckEmptyOrderVisibility() {
            EmptyOrderVisibility=(Orders.Count == 0);
        }
        private void CalcSubtotal()
        {
            SubTotal=Orders.Sum(x=>Convert.ToDouble(x.Item.product.price*x.Item.quantity));
        }

        private void CalcTotalQuantity()
        {
            TotalQuantity = Orders.Sum(x => Convert.ToInt32(x.Item.quantity));
        }

        private void CalcPayment()
        {
            Pay = Orders.Sum(x => Convert.ToDouble(x.Item.product.price * x.Item.quantity));
        }
        public MvxCommand<ProductItemViewModel> GetCartCommand { get; set; }

        private void AddProductsCart(ProductItemViewModel obj)
        {
            var item = Orders.Where(i => i.Item.product.id == obj.Product.id).FirstOrDefault();
            if (item != null)
            {
                int index=Orders.IndexOf(item);
                Orders.ElementAt(index).Item.quantity += 1;
                
            }
            else
            {
                Orders.Add(new OrderItemViewModel(new OrderItem(obj.Product,1)));

            }
            UpdateCart();
           
        }

        private void UpdateCart()
        {
            CheckEmptyOrderVisibility();
            CheckRecylerViewVisibility();
            CalcPayment();
            CalcSubtotal();
            CalcTotalQuantity();
        }

     

    }
}
