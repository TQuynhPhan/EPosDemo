using System;
using System.Collections.Generic;
using System.Text;

namespace EPosDemoMvvm.Core.Services
{
    public class YesNoQuestion
    {
        public Action<bool> YesNoCallback { get; set; }
        public string Question { get; set; }
    }
}
