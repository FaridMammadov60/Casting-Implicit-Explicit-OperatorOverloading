using CastingIpmlicitOverloadigConsoleApp.Models;
using System;

namespace CastingIpmlicitOverloadigConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exchange
            double azn = 170;
            double azn2 = 189;
            double azn3 = 12;
            Console.WriteLine(Exchange(Currecy.USD, azn));
            Console.WriteLine(Exchange(Currecy.EURO, azn2));
            Console.WriteLine(Exchange(Currecy.TRY, azn3));
            #endregion


        }
        static double Exchange(Currecy currecy, double azn)
        {
            double result = 0;

            if (currecy is Currecy)
            {
                if (currecy is Currecy.EURO)
                {
                    result = azn * 0.531915;
                    return result;
                }
                else if (currecy is Currecy.USD)
                {
                    result = azn * 05882352941176471;
                }
                else
                {
                    result = azn * 8.5;
                }

            }
            return result;
        }
    }
  
}
