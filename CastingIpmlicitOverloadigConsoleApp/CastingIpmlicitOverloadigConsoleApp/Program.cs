using CastingIpmlicitOverloadigConsoleApp.Models;
using System;
using System.Text;

namespace CastingIpmlicitOverloadigConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

        L1: Console.Write("Exchange enter 1:\n" +
             "Temperator enter 2: ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    #region Exchange
                    Console.Write("Enter to manat: ");
                    double azn = Convert.ToDouble(Console.ReadLine());
                L2: Console.WriteLine("USD üçün 1\n" +
                     "EURO üçün 2\n" +
                     "TL üçün 3");
                    int pulVahidi = Convert.ToInt32(Console.ReadLine());
                    switch (pulVahidi)
                    {
                        case (int)Currecy.USD:
                            Console.WriteLine($"{Exchange(Currecy.USD, azn)} usd");
                            break;
                        case (int)Currecy.EURO:
                            Console.WriteLine($"{Exchange(Currecy.EURO, azn)} euro");
                            break;
                        case (int)Currecy.TRY:
                            Console.WriteLine($"{Exchange(Currecy.TRY, azn)} tl");
                            break;
                        default:
                            goto L2;
                    }
                    #endregion
                    break;
                case 2:
                    #region Celsius and Kelvin
                  L3:  Console.WriteLine("Celsius to Kelvin enter 1: \n" +
                        "Kelvin to Celsius enter 2: ");
                    int ck=Convert.ToInt32(Console.ReadLine());
                    switch (ck)
                    {
                        case 1:
                            Console.WriteLine("Dərəcəni daxil edin: ");
                            double d=Convert.ToDouble(Console.ReadLine());
                            Celsius cel = new Celsius(d);
                            Kelvin kel = cel;
                            Console.WriteLine($"{kel.Degree} c");
                            break;
                        case 2:
                            Console.WriteLine("Dərəcəni daxil edin: ");
                            double d1 = Convert.ToDouble(Console.ReadLine());
                            Kelvin kel1= new Kelvin(d1);
                            Celsius cel1 = kel1;
                            Console.WriteLine($"{cel1.Degree} k");
                            break;
                        default:
                            goto L3;
                    }                   
                    #endregion
                    break;
                default:
                    Console.WriteLine("Daxil edilən nömre düzgün deyil!!!");
                    goto L1;
            }  

        }
        /// <summary>
        /// Daxil edilmis azn-i dollar euro ve tl-ye ceviri
        /// </summary>
        /// <param name="currecy">Dollar euro ve tl pul vahidi</param>
        /// <param name="azn"></param>
        /// <returns></returns>
        static double Exchange(Currecy currecy, double azn)
        {
            try
            {
                double result = 0;

                if (currecy is Currecy)
                {
                    if (currecy is Currecy.EURO)
                    {
                        result = azn * 0.53;
                        return result;
                    }
                    else if (currecy is Currecy.USD)
                    {
                        result = azn * 0.59;
                    }
                    else
                    {
                        result = azn * 8.5;
                    }

                }
                throw new Exception("Pul vahidi deyil");
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }

}
