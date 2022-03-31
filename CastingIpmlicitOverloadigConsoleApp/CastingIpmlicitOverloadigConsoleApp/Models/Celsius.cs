using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingIpmlicitOverloadigConsoleApp.Models
{
    internal class Celsius
    {
        double _degree;

        public Celsius(double Degree)
        {
            this.Degree = Degree;
        }
        public double Degree 
        { 
            get
            { 
                return _degree;
            }  
            set 
            { 
                _degree = value;
            }
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273);
        }
    }
}
