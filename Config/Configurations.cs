using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSecond.Config
{
    public partial class Configurations
    {
        protected static readonly string AppURL = "YOUR_WEB_URL";

        protected static string Uniqueness = DateTime.Now.ToString("ddMMyyHHmmss");

    }
}

