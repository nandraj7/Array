using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Arithmatic
    {

        public void AdditionOfArray()
        {
            Console.WriteLine("Please Enter Numbers");

            //int num1, num2, num3, num4, num5;

            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Printing The Array");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num[i]);
            }

            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //num3 = Convert.ToInt32(Console.ReadLine());
            //num4 = Convert.ToInt32(Console.ReadLine());
            //num5 = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                result = result + num[i];
            }



            //int result = num[0] + num[1] 
            //           + num[2] + num[3]
            //           + num[4] + num[5]
            //           + num[6] + num[7] 
            //           + num[8] + num[9];
        }
    
        public void PrintAllOddNumbersFromArray()
        {
            Console.WriteLine("Please Enter Numbers");

            int[] num = new int[10];

            for(int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Odd Numbers");
            for (int i = 0; i < 10 ; i++) 
            {
                if (num[i] % 2 == 1)
                {
                    Console.WriteLine(num[i]);
                }
            }

            Console.WriteLine("Even Numbers");
            for (int i = 0; i < 10; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }

        public void ReverseArray()
        {
            Console.WriteLine("Please Enter 5 Numbers");

            int[] num = new int[5];

            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine() ); 
            }

            Console.WriteLine("Array Before Reverse");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("Array After Reverse");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(num[i]); 
            }
        }
    
    }
}
