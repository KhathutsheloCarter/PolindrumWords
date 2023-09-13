using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindum_number
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter  a number");
            int InputNumber = Convert.ToInt32(Console.ReadLine());
            int Remeinder = 0;
            int ReverseNumber = 0;
            int Contigency = InputNumber;

            while (InputNumber > 0)
            {

                InputNumber = InputNumber / 10;
                ReverseNumber = InputNumber % 10;
                Remeinder = ReverseNumber * 10 + Remeinder;
            }

            if (Contigency == ReverseNumber)
            {

                Console.WriteLine("This is a palindum number");
            }
            else
            {
                Console.WriteLine("This is not  a palindum number");
            }
            Console.ReadLine();


        }

     
    }
}
