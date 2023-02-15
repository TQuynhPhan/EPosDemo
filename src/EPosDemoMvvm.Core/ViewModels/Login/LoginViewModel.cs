using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using EPosDemoMvvm.Core.ViewModels.Sale;

namespace EPosDemoMvvm.Core.ViewModels.Login
{
    public class LoginViewModel : MvxViewModel
    {
        private IMvxNavigationService _navigationService;


        public LoginViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new MvxAsyncCommand(Login);

        }

        public override async Task Initialize()
        {
            await base.Initialize();
            EnabledBtn = false;
        }
        private async Task Login()
        {
            if (PinCode == "123")
            {
                LoginFailed = false;
                await _navigationService.Navigate<SaleViewModel>();
            }
            else
                LoginFailed = true;

        }



        public IMvxAsyncCommand NavigateCommand { get; set; }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                SetProperty(ref name, value);
                CheckEnableBtn();
                LoginFailed = false;
            }
        }

        private string pinCode = "";
        public string PinCode
        {
            get => pinCode;
            set
            {
                SetProperty(ref pinCode, value);
                CheckEnableBtn();
                LoginFailed = false;
            }
        }

        private List<string> nameList = new List<string> { "Select your name", "Name 1", "Name 2", "Name 3" };
        public List<string> NameList
        {
            get => nameList;
            set
            {
                SetProperty(ref nameList, value);
            }
        }

        private bool enabledBtn;
        public bool EnabledBtn
        {
            get => enabledBtn;
            set
            {
                SetProperty(ref enabledBtn, value);
            }
        }

        private bool loginFailed=false;
        public bool LoginFailed
        {
            get=> loginFailed;
            set
            {
                SetProperty(ref loginFailed, value);
            }
        }

        private void CheckEnableBtn()
        {
            EnabledBtn =(Name!="Select your name"&&!(string.IsNullOrEmpty(PinCode)));
           
        }

        public MvxCommand<string> InputPinCodeCommand => new MvxCommand<string>(TypeNum);


        private void TypeNum(string obj)
        {
     
            if (obj == "C")
            {
                PinCode = "";
            }
            else if(obj == "x")
            {
                PinCode=(PinCode=="")?"":PinCode.Remove(PinCode.Length-1);
            }
            else
            {
                PinCode = PinCode + obj;
            }
          
        }
    }
}
