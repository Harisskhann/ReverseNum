using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDigit
{
    class Program
    {
        public int Num;

        public void getdetails()
        {
            Console.Write("enter Five digit number = ");
            Num = Convert.ToInt32(Console.ReadLine());



        }
    }
    class five : Program
    {
        int a, b, c, d, e;
        public void findrev()
        {
            e = Num % 10;
            d = (Num / 10) % 10;
            c = (Num / 100) % 10;
            b = (Num / 1000) % 10;
            a = (Num / 10000);
            Num = e * 10000 + d * 1000 + c * 100 + b * 10 + a;
            Console.WriteLine("The Reverse Of Five Digit=" + Num);
            Console.ReadLine();

        }



    }
    class Digit
    {
        static void Main(string[] args)
        {
            var five = new five();
            five.getdetails();
            five.findrev();

        }


}   }