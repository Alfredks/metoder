using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter
{
    class Program
    { /*
        static int CelsiusToFarenheit(int celsius)
        {
            return (((celsius / 5) * 9) + 32);
            }
        static void Main(string[] args)
        {
            Console.WriteLine("mata in grader celsius");
            int grader = int.Parse(Console.ReadLine());
            Console.WriteLine(CelsiusToFarenheit(grader));
        } 
        static double CirkelArea(double radie)
        {
            return (radie * radie * Math.PI);
        }
        static double CirkelOmkrets(double radie)
        {
            return (radie * 2 * Math.PI);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("mata in en radie");
            double radie = double.Parse(Console.ReadLine());
            Console.WriteLine("Cirkelns area: " + Math.Round(CirkelArea(radie)));
            Console.WriteLine("cirkelns omkrets: " + Math.Round(CirkelOmkrets(radie))); 
        static int CelsiusToFarenheit(int celsius)
        {
        return((celsius /5) * 9 + 32);
        }
static void Main(string[] args)
    {
        Console.WriteLine("mata in ett heltal");
        int grader = int.Parse(Console.ReadLine());
        Console.WriteLine(CelsiusToFarenheit(grader)); */

        static double CirkelArea(double radie)
        {
            return (radie * radie * Math.PI);
        }
        static double CirkelOmkrets (double radie)
        {
            return (radie * radie * Math.PI * 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("mata in ett tal");
            double radie = double.Parse(Console.ReadLine());
            Console.WriteLine("cirkels area : " + Math.Round(CirkelArea(radie)));
            Console.WriteLine("cirkels area : " + Math.Round(CirkelOmkrets(radie)));
        
             }
        }
    }

