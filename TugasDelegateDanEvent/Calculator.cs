using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasDelegateDanEvent
{
    public class Calculator
    {
        public int Penambahan(int a, int b)
        {
            return a + b;
        }

        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        public int Perkalian(int a, int b)
        {
            return a * b;
        }

        public float Pembagian(int a, float b)
        {
            return a / b;
        }
    }
}
