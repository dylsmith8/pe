using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class Helpers
    {
        private static char[] SplitString(string literal)
        {
            literal = literal.Replace("\n", "");
            literal = literal.Replace("\t", "");
            literal = literal.Replace("\r", "");
            return literal.ToCharArray();
        }
    }
}
