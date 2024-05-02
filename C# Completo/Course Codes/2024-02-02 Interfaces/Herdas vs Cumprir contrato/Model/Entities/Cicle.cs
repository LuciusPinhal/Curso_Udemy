using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Model.Entities
{
    class Cicle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Cicle Color = " 
                + Color 
                + ", Radius = " 
                + Radius.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Area= " 
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
