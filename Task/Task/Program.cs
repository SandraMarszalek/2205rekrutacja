using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task
{
    class Zabawa
    { 
        private const double w = 1.5;
        int h = 0;
        double b = 0.0;

        

        public int Gra(int h, double b)
        {
            if (h < 1 || b < 0 || b >=1 )
            {
                return -1;
            }
            var widoczna = 1;

            for (double aktualna_wys = h; aktualna_wys >= widoczna;)
            {
                aktualna_wys *= b;
                widoczna += 2; 
            }
            return widoczna;

            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
