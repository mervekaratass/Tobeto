using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Question7
    {
        //kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen ve
        //daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.(For döngüsü kullanınız)

        public void GetAggregate()
        {
            Console.Write("Öğrenci sayısını giriniz:");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine();
                Console.WriteLine((i + 1) + " . Öğrenci");
                Console.WriteLine("----------------------------------------------------");

                Console.Write("Adı:");
                string name = Console.ReadLine();

                Console.Write("Soyadı:");
                string surname = Console.ReadLine();

                Console.Write("1.sınav notu:");
                double exam_1 = double.Parse(Console.ReadLine());

                Console.Write("2.sınav notu:");
                double exam_2 = double.Parse(Console.ReadLine());

                Console.Write("3.sınav notu:");
                double exam_3 = double.Parse(Console.ReadLine());

                double avverage = (exam_1 + exam_1 + exam_3) / 3;
                Console.WriteLine("Not ortalaması:" + avverage);



            }
        }
    }
}
