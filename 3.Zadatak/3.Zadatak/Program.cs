using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, x, y, a, b, c, d;


            for ( i = 1; i <= 33; i++) { 
            
            for ( x = 2; x <= 34; x++)
                {
            for ( y = 3; y <= 35; y++)
                    {
            for ( a = 4; a <= 36; a++)
                        {
            for ( b = 5; b <= 37; b++)
                            {
            for ( c = 6; c <= 38; c++)
                                {
            for ( d = 7; d <= 39; d++)
                                    {
            Console.WriteLine(i + " " + x + " " + y + " " + a + " " + b + " " + c + " " + d);
                                    }

                                }
                            }
                        }
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
        
