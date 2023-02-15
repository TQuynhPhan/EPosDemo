using Foundation;
using MvvmCross.Platforms.Ios.Core;
using EPosDemoMvvm.Core;

namespace EPosDemoMvvm.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
