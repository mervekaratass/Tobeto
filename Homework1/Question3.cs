using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Question3
    {
        //Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.
        public void Loop()
        {
            //While -> Programlarda verilen koşul sağlandığı müddetçe dönmeye devam eden döngüdür.

            int i = 5;
            while (i > 0)
            {
                Console.WriteLine(i + "  -->Koşul sağlanıyor");

                i--;
            }
            Console.WriteLine("Koşul sağlanmadı ve döngüden çıktı");

            Console.WriteLine("-------------------");

            //Do-While -> En başta koşula bakmadan bir kez çalışıtırılması gereken durumlarda kullanılır.Bir kez çalıştıktan sonra artık koşula bakar.

            int j = 5;
            do
            {
                Console.WriteLine(j);
                j++;

            } while (j < 5);
        }
    }
}
