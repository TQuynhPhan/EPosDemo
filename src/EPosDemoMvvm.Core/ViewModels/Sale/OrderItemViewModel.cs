using System;
using System.Collections.Generic;
using System.Text;
using EPosDemoMvvm.Core.Services;
using MvvmCross.ViewModels;

namespace EPosDemoMvvm.Core.ViewModels.Sale
{
    public class OrderItemViewModel:MvxViewModel
    {
        private OrderItem _item;
        public OrderItem Item
        {
            get => _item;
            set
            {
                SetProperty(ref _item, value);  
            }
        }

        public OrderItemViewModel(OrderItem item)
        {
            _item = item;
        }
    }
}
