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
using EPosDemoMvvm.Core.Services;
using EPosDemoMvvm.Core.ViewModels.Sale;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views.Fragments;

namespace EPosDemoMvvm.Droid.Views.Sale
{
    [MvxFragmentPresentation(typeof(SaleViewModel), Resource.Id.fragmentProduct)]
    [Register(nameof(ProductFragView))]

    public class ProductFragView:MvxFragment<ProductViewModel>
    {
        public override void OnCreate(Bundle savedInstanceState) => base.OnCreate(savedInstanceState);

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            View view = this.BindingInflate(Resource.Layout.fragment_product, null);

            var set = this.CreateBindingSet<ProductFragView, ProductViewModel>();

            MvvmCross.DroidX.RecyclerView.MvxRecyclerView recyclerViewProduct = view.FindViewById<MvvmCross.DroidX.RecyclerView.MvxRecyclerView>(Resource.Id.recyclerViewProduct);
            recyclerViewProduct.SetLayoutManager(new GridLayoutManager(Activity, 5));
            var adapter = new ProductAdapter((IMvxAndroidBindingContext)BindingContext);
            recyclerViewProduct.Adapter = adapter;
            

            set.Bind(recyclerViewProduct).For(v => v.ItemsSource).To(vm => vm.Products);
            set.Bind(recyclerViewProduct).For(v => v.ItemClick).To(vm => vm.AddProductCommand);
            set.Apply();


            return view;
        }
    }
}
