using System;
using System.Collections.Generic;
using System.Text;

namespace WindowServiceBoilerplate.Configuration
{
    public class QuartzConfig
    {
        public const string quartzConfig = "QuartzConfig";
        public int IntervalInMinute { get; set; }
    }
}
