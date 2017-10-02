using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public class krugClass : Interface1
    {
        private double r;

        public krugClass(double r)
        {
            this.r = r;
        }

        public double vozrat()
        {
            return this.calc();
        }

        private double calc()
        {
            return 3.14 * (this.r * this.r);
        }

        double Interface1.calc()
        {
            throw new NotImplementedException();
        }
    }
}
