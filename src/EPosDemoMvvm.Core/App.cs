using MvvmCross.IoC;
using MvvmCross.ViewModels;
using EPosDemoMvvm.Core.ViewModels.Main;
using EPosDemoMvvm.Core.ViewModels.Login;
using MvvmCross;
using EPosDemoMvvm.Core.Services;

namespace EPosDemoMvvm.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<LoginViewModel>();
        }
    }
}
