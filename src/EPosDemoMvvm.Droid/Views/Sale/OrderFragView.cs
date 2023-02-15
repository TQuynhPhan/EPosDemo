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
using EPosDemoMvvm.Core.Converters;
using EPosDemoMvvm.Core.ViewModels.Sale;
using MvvmCross.Base;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views.Fragments;
using MvvmCross.ViewModels;

namespace EPosDemoMvvm.Droid.Views.Sale
{
    [MvxFragmentPresentation(typeof(SaleViewModel), Resource.Id.fragmentOrder)]

    [Register(nameof(OrderFragView))]
    public class OrderFragView:MvxFragment<OrderViewModel>
    {
        OrderAdapter adapter;
        public override void OnCreate(Bundle savedInstanceState) => base.OnCreate(savedInstanceState);
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            View view = this.BindingInflate(Resource.Layout.fragment_order, null);


            TextView txtEmptyOrder=view.FindViewById<TextView>(Resource.Id.txtEmptyOrder);

            MvvmCross.DroidX.RecyclerView.MvxRecyclerView recyclerViewOrder = view.FindViewById<MvvmCross.DroidX.RecyclerView.MvxRecyclerView>(Resource.Id.recyclerViewOrder);

            TextView txtNo = view.FindViewById<TextView>(Resource.Id.txtNo);
            TextView txtSubtotal = view.FindViewById<TextView>(Resource.Id.txtSubtotal);
            TextView txtDiscount = view.FindViewById<TextView>(Resource.Id.txtDiscount);
            TextView txtPromotion = view.FindViewById<TextView>(Resource.Id.txtPromotion);
            TextView txtTax = view.FindViewById<TextView>(Resource.Id.txtTax);
            TextView txtTotalQuantity = view.FindViewById<TextView>(Resource.Id.txtTotalQuantity);
            Button btnPay = view.FindViewById<Button>(Resource.Id.btnPay);

            recyclerViewOrder.SetLayoutManager(new LinearLayoutManager(Activity));
            adapter = new OrderAdapter((IMvxAndroidBindingContext)BindingContext);
            recyclerViewOrder.Adapter= adapter;
            recyclerViewOrder.AddItemDecoration(new DividerItemDecoration(Activity, DividerItemDecoration.Vertical));
          

            var set = this.CreateBindingSet<OrderFragView, OrderViewModel>();
            set.Bind(txtEmptyOrder).For("Visible").To(vm => vm.EmptyOrderVisibility);
            set.Bind(recyclerViewOrder).For("Visible").To(vm => vm.RecyclerViewVisibility);
            set.Bind(recyclerViewOrder).For(v => v.ItemsSource).To(vm => vm.Orders);
            set.Bind(txtSubtotal).For(v => v.Text).To(vm => vm.SubTotal).WithConversion("SubTotal");
            set.Bind(txtTotalQuantity).For(v => v.Text).To(vm => vm.TotalQuantity);
            set.Bind(btnPay).For(v=>v.Text).To(vm => vm.Pay).WithConversion("Payment");
            set.Bind(btnPay).For("Click").To(vm => vm.PayCartCommand);
            set.Bind(btnPay).For("Enabled").To(vm => vm.RecyclerViewVisibility);
            set.Bind(this).For(v => v.Interaction).To(vm => vm.Interaction).OneWay();
            set.Apply();
            return view;
        }

        private IMvxInteraction<YesNoQuestion> _interaction;
        public IMvxInteraction<YesNoQuestion> Interaction
        {
            get => _interaction;
            set
            {
                if (_interaction != null)
                    _interaction.Requested -= OnInteractionRequested;

                _interaction = value;
                _interaction.Requested += OnInteractionRequested;
            }
        }

        private async void OnInteractionRequested(object sender, MvxValueEventArgs<YesNoQuestion> eventArgs)
        {
            var yesNoQuestion = eventArgs.Value;
          

            AlertDialog.Builder dialog = new AlertDialog.Builder(Activity);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(yesNoQuestion.Question);

            alert.SetButton("Yes", (sender, e) =>
            {
                yesNoQuestion.YesNoCallback(true);
            });
            alert.SetButton2("No", (sender, e) =>
            {
                yesNoQuestion.YesNoCallback(false);
            });
            alert.Show();


        }

      
    }
}
