using System;
using System.Collections.Generic;
using System.Text;

namespace EPosDemoMvvm.Core.Services
{
    public class OrderItem: MvvmCross.ViewModels.MvxNotifyPropertyChanged
    {
        public Product product { get; set; }

        private int _quantity;
        public int quantity
        {
            get => _quantity;
            set
            {
                SetProperty(ref _quantity, value);
            }
        }

        public OrderItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}
