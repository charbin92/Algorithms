using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApps
{
    public static class ExtensionMethods
    {
        public static bool isEven(this int i)
        {
            return i % 2 == 0;
        }
    }
}
