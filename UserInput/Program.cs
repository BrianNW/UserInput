using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            //WriteLine takes in below method
            Console.Read();
            //Stops app from closing
        }

        public static int Calculate()
        {
            Console.WriteLine("please enter the first number: ");
            string number1Input = Console.ReadLine();
            Console.WriteLine("please enter the second number: ");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;

            return result;
        }
    }
}
