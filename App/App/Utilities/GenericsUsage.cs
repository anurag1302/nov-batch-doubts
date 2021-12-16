using System.Collections.Generic;

namespace App.Utilities
{
    public class GenericsUsage<T> where T : class
    {
        public GenericsUsage(int a, int b)
        {
            A = a;
            B = b;
        }
        public int A { get; set; }
        public int B { get; set; }
        public List<T> Records { get; set; }
    }

    public class GenericsUsageAlt<T>
    {
        public List<T> Records { get; set; }
    }
}
