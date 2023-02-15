using Android.App;
using Android.OS;
using AndroidX.Lifecycle;
using EPosDemoMvvm.Core.ViewModels.Sale;
using EPosDemoMvvm.Droid;
using EPosDemoMvvm.Droid.Views.Sale;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using AndroidX.Fragment.App;
using Android.Widget;
using EPosDemoMvvm.Core.Services;

namespace EPosDemo.Droid.Views.Sale
{
    [MvxActivityPresentation]
    [Activity(Label = "Sale View")]
    public class SaleView : MvxActivity<SaleViewModel>
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_sale);

            ViewModel.navigate();
        }
    }

}
