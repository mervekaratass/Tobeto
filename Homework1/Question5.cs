using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Question5
    {
        // Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

        public void IsExcellent()
        {

            Console.Write("Bir sayı giriniz:");
            int number = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = 1; i < number; i++)
            {

                if (number % i == 0)
                    total += i;


            }

            if (total == number)
                Console.WriteLine(number + " mükemmel bir sayıdır.");
            else
                Console.WriteLine(number + " mükemmel bir sayı değildir.");
        }
    }
}
