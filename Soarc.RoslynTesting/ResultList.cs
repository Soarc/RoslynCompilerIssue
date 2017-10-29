using System;
using System.Collections.Generic;
using System.Text;

namespace Soarc.RoslynTesting
{
    public class ResultList
    {       
        public ResultModel[] Models { get; set; }

        public string Continuation { get; set; }
    }
}
