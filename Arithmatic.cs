using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public void FindMaxNumberFromArray()
        {
            //int[] num = new int[] { 11, 22, 34, 56, 78, 90,43, 45, 76, 83 };

            int[] num = new int[10];

            Console.WriteLine("Please Enter 10 Numbers :");

            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = num[0];

            for (int i = 1; i < 10;  i++)
            {
                if (max < num[i])
                {
                    max = num[i];  
                }
            }
            Console.WriteLine("The maximum Number = " + max);
        }
        
        public void FindMinNumberFromArray()
        {
            int[] num = new int[] { 110, 22, 34, 56, 78, 90,43, 45, 76, 83 };

            //int[] num = new int[10];

            //Console.WriteLine("Please Enter 10 Numbers :");

            //for (int i = 0; i < 10; i++)
            //{
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            int min = num[0];

            for (int i = 1; i > 10; i++)
            {
                if (min < num[i])
                {
                    min = num[i];
                }
            }
            Console.WriteLine("The minimum Number = " + min);
        }

        public void BubbleShort()
        {
            int[] num = new int[] { 34, 45, 67, 76, 89, 87, 76, 83, 92, 71 };

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (num[i] > num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;

                    }
                }
            }

           for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num[i]);
            }
        }

        public void SwappingTwoNumbersWithoutThirdVariable()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Values Before Swapping");
            Console.WriteLine("a = " +a +"b = " +b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Values After Swapping");
            Console.WriteLine("a = " +a + "b = " +b);
        }

        


    }
}
