using NPOI.SS.Formula.Functions;
using System;

namespace Generics
{
    public class Utilities
    {
        //public int Max(int a, int b)
        //{
        //    return a >= b ? a : b;
        //}

        //Fantascienza
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    //Fantascienza volume 2
    public class Utilities<T> where T : IComparable, new()
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        public void DoSomething(T Value)
        {
            var obj = new T();
        }
    }
}
