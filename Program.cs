using System;
using System.Runtime.ExceptionServices;

namespace calculatorMenagerie
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu
            Console.WriteLine("Menu\n1.add\n2.subtract\n3.multiply\n4.divide");
            var menuAnswer = Console.ReadLine();

            //variables
            var alpha = 0.0;
            var beta = 0.0;
            var result = 0.0;

            if (menuAnswer == "1" || menuAnswer == "2" || menuAnswer == "3" || menuAnswer == "4")
                {
            
             //get variables
            Console.Write("First Number: ");
            alpha = double.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            beta = double.Parse(Console.ReadLine());


                if (menuAnswer == "1")
                    {
                    //add
                    result = alpha + beta;

                }
                else if (menuAnswer == "2")
                        {
                    //subtract
                    result = alpha - beta;

                }
                else if (menuAnswer == "3")
                         {
                    //multiply
                    result = alpha * beta;

                }
                else if (menuAnswer == "4")
                         {
                    //divide
                    result = alpha / beta;
                }
            
            Console.WriteLine($"Your Answer Is {result}");            
            
            }
            else
            {
                Console.WriteLine("The Nine are disappointed....");
            }




        }
    }
}
