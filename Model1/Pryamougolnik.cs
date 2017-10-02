using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public class pryaClass : Interface1
    {
        private double a;
        private double b;

        public pryaClass(double a, double b)
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
            return this.a * this.b;
        }

        double Interface1.calc()
        {
            throw new NotImplementedException();
        }
    }
}
