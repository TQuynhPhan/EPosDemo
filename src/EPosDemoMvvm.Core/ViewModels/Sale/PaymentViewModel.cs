using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace EPosDemoMvvm.Core.ViewModels.Sale
{
    public class PaymentViewModel:MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public PaymentViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override Task Initialize() => base.Initialize();

        public MvxCommand BackCommand => new MvxCommand(BackScreen);

        private void BackScreen()
        {
            _navigationService.Close(this);
        }
    }
}
