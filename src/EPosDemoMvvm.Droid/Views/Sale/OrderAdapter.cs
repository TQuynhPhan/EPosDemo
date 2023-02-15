using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EPosDemoMvvm.Core.ViewModels.Sale;
using MvvmCross.Binding.BindingContext;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using static AndroidX.RecyclerView.Widget.RecyclerView;

namespace EPosDemoMvvm.Droid.Views.Sale
{
    public class OrderAdapter:MvxRecyclerAdapter
    {
        public OrderAdapter(IMvxAndroidBindingContext bindingContext)
        : base(bindingContext)
        {
        }

        public override ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemBindingContext = new MvxAndroidBindingContext(parent.Context, BindingContext.LayoutInflaterHolder);
            var view = InflateViewForHolder(parent, viewType, itemBindingContext);

            return new OrderViewHolder(view, itemBindingContext);
        }
    }

    public class OrderViewHolder : MvxRecyclerViewHolder
    {
        public OrderViewHolder(View itemView, IMvxAndroidBindingContext context)
            : base(itemView, context)
        {

            TextView txtOrderItemQuantity, txtOrderItemName, txtOrderItemPrice;
            

            txtOrderItemQuantity = itemView.FindViewById<TextView>(Resource.Id.txtOrderItemQuantity);
            txtOrderItemName = itemView.FindViewById<TextView>(Resource.Id.txtOrderItemName);
            txtOrderItemPrice = itemView.FindViewById<TextView>(Resource.Id.txtOrderItemPrice);

            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<OrderViewHolder, OrderItemViewModel>();
                
                set.Bind(txtOrderItemQuantity).For(v => v.Text).To(vm => vm.Item.quantity);
                set.Bind(txtOrderItemName).For(v => v.Text).To(vm => vm.Item.product.name);
                set.Bind(txtOrderItemPrice).For(v => v.Text).To(vm => vm.Item.product.price).WithConversion("SubTotal");

                set.Apply();
            });

        }
    }
}
