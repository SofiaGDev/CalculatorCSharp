using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int symbol = 0;
            int num1;
            int num2;
            int num3 = 0;
            bool validation =false;

            

            while (validation == false)
            {
                Console.WriteLine("Hello, welcome to a calculator, choose the type of calculation you want to do ");

                Console.WriteLine("+ = 1 \n- = 2 \n* = 3 \n/ = 4");

                symbol = Convert.ToInt32(Console.ReadLine());

                if (symbol < 1 || symbol > 4)
                {

                    Console.WriteLine("WRONG");
                    continue;

                }
                else
                {
                    validation = true;


                }

            }

            Console.WriteLine("enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            switch (symbol)
            {
                case 1:
                    num3 = num1 + num2;
                        break;

               case 2:
                num3 = num1 - num2;
                    break;

                case 3:
                    num3 = num1 * num2;
                    break;

                case 4:
                    num3 = num1 / num2;
                    break;
            }

            Console.WriteLine("the result is " + num3);
            Console.ReadKey();
        }
    }
}
