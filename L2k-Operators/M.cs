using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2k_Operators
{
    public class M
    {
        int[] _mas;

        public M(int size) {
            _mas = new int[size];
        }

        public M(params int[] mas)
        {
            _mas = new int[mas.Length];
            Array.Copy(mas, _mas, mas.Length);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in _mas)
            {
                sb.Append(i.ToString());
                sb.Append(", ");
            }
            return sb.ToString();
        }

        public static M operator +(M m1, M m2)
        {
            var maxSz = Math.Max(m1._mas.Length, m2._mas.Length);
            var ms = new int[maxSz];
            Array.Copy(m1._mas.Length == maxSz ? m1._mas : m2._mas, ms, maxSz);
            var minSz = Math.Min(m1._mas.Length, m2._mas.Length);
            for (int i = 0; i < minSz; i++)
            {
                ms[i] = m1._mas[i] + m2._mas[i];
            }
            return new M(ms);
        }

        public static M operator -(M m1)
        {
            var ms = new int[m1._mas.Length];
            Array.Copy(m1._mas, ms, m1._mas.Length);
            for (int i = 0; i < ms.Length; i++)
            {
                ms[i] *= -1;
            }
            return new M(ms);
        }

        public static bool operator ==(M m1, M m2)
        {
            if (m1 is null || m2 is null) return false;
            if (m1._mas.Length != m2._mas.Length) return false;
            for (int i = 0;i < m1._mas.Length; i++)
            {
                if (m1._mas[i] != m2._mas[i]) return false;
            }
            return true;
        }

        public static bool operator !=(M m1, M m2)
        {
            return !(m1 == m2);
        }

        public static explicit operator M(int m1) {
            return new M(m1); 
        }

        public static implicit operator int[](M m1)
        {
            return m1._mas;
        }

        public static implicit operator M(int[] m1)
        {
            return new M(m1);
        }
    }
}
