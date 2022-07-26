using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Helpers
{
    //public interface IComparable<T> where T : struct // Simplified version of interface
    //{
    //    int CompareTo(T other);
    //}

    public class Extensions
    {
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
