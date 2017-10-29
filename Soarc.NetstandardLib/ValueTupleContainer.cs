using System;
using System.Collections.Generic;
using System.Text;

namespace Soarc.NetstandardLib
{
    public class ValueTupleContainer
    {
        public static (string ArgZero,string ArgSubzero) GetArgs()
        {
            return (string.Empty, string.Empty);
        }
    }
}
