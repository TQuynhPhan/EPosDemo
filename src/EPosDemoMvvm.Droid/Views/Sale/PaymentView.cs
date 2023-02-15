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
using MvvmCross.Platforms.Android.Views;
using AndroidX.AppCompat.Widget;
using MvvmCross.Binding.BindingContext;

namespace EPosDemoMvvm.Droid.Views.Sale
{
    [Activity(Label ="Payment")]
    public class PaymentView:MvxActivity<PaymentViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_payment);

            Button btnBack = FindViewById<Button>(Resource.Id.btnBack);

            var set = this.CreateBindingSet<PaymentView, PaymentViewModel>();
            set.Bind(btnBack).For("Click").To(vm => vm.BackCommand);
            set.Apply();
        }

        
    }
}
