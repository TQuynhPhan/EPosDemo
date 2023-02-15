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
using AndroidX.RecyclerView.Widget;
using EPosDemoMvvm.Core.ViewModels.Sale;
using MvvmCross;
using MvvmCross.Binding.BindingContext;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using static AndroidX.RecyclerView.Widget.RecyclerView;

namespace EPosDemoMvvm.Droid.Views.Sale
{
    public class ProductAdapter:MvxRecyclerAdapter
    {
        public ProductAdapter(IMvxAndroidBindingContext bindingContext)
        : base(bindingContext)
        {
        }

        public override ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemBindingContext = new MvxAndroidBindingContext(parent.Context, BindingContext.LayoutInflaterHolder);
            var view = InflateViewForHolder(parent, viewType, itemBindingContext);

            return new ProductViewHolder(view, itemBindingContext);
        }
    }

    public class ProductViewHolder : MvxRecyclerViewHolder
    {
        public ProductViewHolder(View itemView, IMvxAndroidBindingContext context)
            : base(itemView, context)
        {
            FFImageLoading.Cross.MvxCachedImageView imgProduct;
            TextView txtNameProduct;
            TextView txtPriceProduct;

            imgProduct = itemView.FindViewById<FFImageLoading.Cross.MvxCachedImageView>(Resource.Id.imgProduct);
            txtNameProduct = itemView.FindViewById<TextView>(Resource.Id.txtNameProduct);
            txtPriceProduct = itemView.FindViewById<TextView>(Resource.Id.txtPriceProduct);
            
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<ProductViewHolder, ProductItemViewModel>();

                set.Bind(imgProduct).For(v => v.ImagePath).To(vm => vm.Product.image);
                 
                set.Bind(txtNameProduct).For(v => v.Text).To(vm => vm.Product.name);
                set.Bind(txtPriceProduct).For(v=>v.Text).To(vm => vm.Product.price).WithConversion("SubTotal");
                
                set.Apply();
            });
            
        }
    }
}
