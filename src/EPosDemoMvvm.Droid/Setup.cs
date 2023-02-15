using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Android.Core;
using EPosDemoMvvm.Core;
using Serilog;
using Serilog.Extensions.Logging;
using MvvmCross.Platforms.Android.Presenters;
using MvvmCross;

namespace EPosDemoMvvm.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override ILoggerProvider CreateLogProvider() => new SerilogLoggerProvider();

        protected override ILoggerFactory CreateLogFactory()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }
    }
}
