using System;
namespace loops
{
    class Loopsss
    {
        public static void Main()
        {
            int i;
            int sum = 0;
            int n, cube;
            double avg;

            //for( i = 1; i <= 10; i++)
            //{
            //    Console.Write(i + " ");

            //    sum += i;

            //} 
            //Console.WriteLine("\n");
            //Console.WriteLine("The sum is " + sum);

            //Console.WriteLine("Enter a Natural Number");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= n; i++)
            //{
            //    Console.Write(i + " ");

            //    sum += i;

            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("The sum of natural numbers up to " + n + " is " + sum);

            //Console.WriteLine("Input 10 numbers");
            ////for(i = 1; i <= 10; i++)
            //{
            //    //Console.WriteLine(i);
            //    n = Convert.ToInt32(Console.ReadLine());
            //    sum += n;
            //}
            //Console.WriteLine($"The sum is {sum}");
            //avg = sum / 10;
            //Console.WriteLine($"The average is {avg}");

            //Console.WriteLine("Input any number");
            //n = Convert.ToInt32(Console.ReadLine());
            //for(i = 1; i <= n; i++)
            //{
            //    cube = i * i * i; 
            //    Console.WriteLine($"The cube of {i} is {cube}");
            //}
            //  MULTIPLICATION TABLE
            //Console.WriteLine("Input any number to get multiplication table");
            //n = Convert.ToInt32(Console.ReadLine());
            //for(i = 1; i <= 12; i++)
            //{
            //    int table = n * i;
            //    Console.WriteLine(n + " x " + i + " is " + table);
            //}

            //Console.Write("Input upto the table number starting from 1 : ");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Multiplication table from 1 to {0} \n", n);
            //for (i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (j <= n - 1)
            //            Console.Write("{0}x{1} = {2}, ", j, i, i * j);
            //        else
            //            Console.Write("{0}x{1} = {2}", j, i, i * j);

            //    }
            //    Console.Write("\n");
            //}

            //Console.Write("Input number of terms : ");
            //n = Convert.ToInt32(Console.ReadLine());
            //for(i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    sum += i;

            //}
            //Console.WriteLine("The sum is " + sum);

           
            //Console.Write("Six rows of asterisk: ");
            //for (i = 1; i <= 6; i++)
            //{
            //    for (int j = 1; j <= i; j++)
                
            //        Console.WriteLine("*");
            //        Console.Write("\n");
            //}

            Console.Write("Six rows of numbers in a triangle: ");
            for (i = 0; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                Console.Write(j +" ");
                    
                    Console.Write("\n");
            }





        }
    }
}
