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
using EPosDemoMvvm.Core.ViewModels.Login;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding.Views;
using MvvmCross.Platforms.Android.Views;

namespace EPosDemoMvvm.Droid.Views.Login
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginView : MvxActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);

            EditText edtPinCode = FindViewById<EditText>(Resource.Id.edtPinCode);
            MvxSpinner spinnerName = FindViewById<MvxSpinner>(Resource.Id.spinnerName);
            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            Button btnNumpad0 = FindViewById<Button>(Resource.Id.btnNumpad0);
            Button btnNumpad1 = FindViewById<Button>(Resource.Id.btnNumpad1);
            Button btnNumpad2 = FindViewById<Button>(Resource.Id.btnNumpad2);
            Button btnNumpad3 = FindViewById<Button>(Resource.Id.btnNumpad3);
            Button btnNumpad4 = FindViewById<Button>(Resource.Id.btnNumpad4);
            Button btnNumpad5 = FindViewById<Button>(Resource.Id.btnNumpad5);
            Button btnNumpad6 = FindViewById<Button>(Resource.Id.btnNumpad6);
            Button btnNumpad7 = FindViewById<Button>(Resource.Id.btnNumpad7);
            Button btnNumpad8 = FindViewById<Button>(Resource.Id.btnNumpad8);
            Button btnNumpad9 = FindViewById<Button>(Resource.Id.btnNumpad9);
            Button btnNumpadClearAll = FindViewById<Button>(Resource.Id.btnNumpadClearAll);
            Button btnNumpadClearNum = FindViewById<Button>(Resource.Id.btnNumpadClearNum);
            TextView txtLoginFailed=FindViewById<TextView>(Resource.Id.txtLoginFailed);

            var set = this.CreateBindingSet<LoginView, LoginViewModel>();
            set.Bind(edtPinCode).For(v => v.Text).To(vm => vm.PinCode);

            set.Bind(spinnerName).For(v => v.SelectedItem).To(vm => vm.Name);
            set.Bind(spinnerName).For(v => v.ItemsSource).To(vm => vm.NameList);
            
            set.Bind(btnLogin).For("Click").To(vm => vm.NavigateCommand);
            set.Bind(btnLogin).For("Enabled").To(vm => vm.EnabledBtn);

            set.Bind(btnNumpad0).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("0");
            set.Bind(btnNumpad1).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("1");
            set.Bind(btnNumpad2).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("2");
            set.Bind(btnNumpad3).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("3");
            set.Bind(btnNumpad4).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("4");
            set.Bind(btnNumpad5).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("5");
            set.Bind(btnNumpad6).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("6");
            set.Bind(btnNumpad7).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("7");
            set.Bind(btnNumpad8).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("8");
            set.Bind(btnNumpad9).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("9");
            set.Bind(btnNumpadClearAll).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("C");
            set.Bind(btnNumpadClearNum).For("Click").To(vm => vm.InputPinCodeCommand).CommandParameter("x");

            set.Bind(txtLoginFailed).For("Visible").To(vm => vm.LoginFailed);

            set.Apply();
        }


    }
}
