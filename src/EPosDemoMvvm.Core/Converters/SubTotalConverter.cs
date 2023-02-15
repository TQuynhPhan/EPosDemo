using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MvvmCross.Converters;

namespace EPosDemoMvvm.Core.Converters
{
    public class SubTotalConverter:MvxValueConverter<double,string>
    {
        protected override string Convert(double value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Format(new CultureInfo("en-US"), "{0:C}", value).Replace("$","");
        }
    }
}
