using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public class treClass : Interface1
    {
        private double a;
        private double b;

        public treClass(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double vozrat()
        {
            return this.calc();
        }

        private double calc()
        {
            return (0.5 * this.a) * this.b;
        }

        double Interface1.calc()
        {
            throw new NotImplementedException();
        }
    }
}
