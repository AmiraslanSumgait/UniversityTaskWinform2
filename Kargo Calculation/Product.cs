using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kargo_Calculation
{
    abstract public class Product
    {
        public double Price { get; set; }
        public  abstract double Calculate();
    }
    public class DangerousProduct : Product
    {
        public override double Calculate()
        {
            return Price+=3;
        }
    }
    public class LiquidProduct : Product
    {
        public override double Calculate()
        {
            return Price +=1;
        }
    }
    public class SolidProduct : Product
    {
        public override double Calculate()
        {
            return Price *= 0.8;
        }
    }
}
