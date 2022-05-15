using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperators
{
    internal class CodeHelper
    {
        public static string UseCNullCoalescingAssignment(string s = null)
        {
            //The ??= operator assigns a variable only if it’s nul
            // if (s == null) s = "Hello, world";

            return s ??= "string instead Of NULL.";
        }
    }
}