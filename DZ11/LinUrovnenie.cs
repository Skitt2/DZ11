using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ11
{
    struct LinUrovnenie
    {
        double k;
        double b;

        public LinUrovnenie(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0 && b != 0)
                return "Решений нет";
            if (k == 0 || b == 0)
                return "Является любое число";
            double x = k / b;
            return $"Решение уравнения = {x}";
        }

    }
}
