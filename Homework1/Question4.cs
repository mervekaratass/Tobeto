using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Question4
    {
        public void GetNumberGuess()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            Console.WriteLine("Sayı tahmin oyununa hoşgeldiniz !!!");
            Console.WriteLine("1 ile 10 arasında bir sayı tuttum.Bakalım bulucak mısınız?");

            bool check = true;
            do
            {

                Console.Write("Tahmin:");
                int guess = int.Parse(Console.ReadLine());


                if (number == guess)
                {
                    Console.WriteLine("Doğru tahmin.Tuttuğum sayı " + number + " di.Tebrikler...");
                    check = false;
                }
                else
                {
                    Console.WriteLine("Yanlış tahminde bulundunuz.Tekrar dene. ");
                    check = true;

                }
            }
            while (check);

        }
    }
}
