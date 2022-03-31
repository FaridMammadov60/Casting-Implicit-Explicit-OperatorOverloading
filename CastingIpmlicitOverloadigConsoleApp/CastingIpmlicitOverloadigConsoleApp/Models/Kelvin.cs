using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingIpmlicitOverloadigConsoleApp.Models
{
    internal class Kelvin
    {
        double _degree;
        public Kelvin(double Degree)
        {
            this.Degree = Degree;
        }
        public double Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }


        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Degree -273);
        }
    }
}
