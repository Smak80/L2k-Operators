using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2k_Operators
{
    public class Counter
    {
        private static int _count;
        private int _id;
        public static int Count => _count;
        public int Id => _id;

        public Counter()
        {
            _id = _count++;
        }

        public static string IdCount(Counter m)
        {
            return $"{m.Id}/{Count}";
        }
    }
}
