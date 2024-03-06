using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Question1
    {
        //Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.Input için Scanner kullanınız
        public void GetOrder()
        {
            Console.Write("Sipariş no giriniz (1-5) : ");
            int orderNo = int.Parse(Console.ReadLine());
            bool check = true;
            do
            {
                switch (orderNo)
                {
                    case 1:
                        Console.WriteLine("Telefon siparişiniz alınmıştır");
                        check = false;
                        break;
                    case 2:
                        Console.WriteLine("Laptop siparişiniz alınmıştır");
                        check = false;
                        break;
                    case 3:
                        Console.WriteLine("Kulaklık siparişiniz alınmıştır");
                        check = false;
                        break;
                    case 4:
                        Console.WriteLine("Kulaklık siparişiniz alınmıştır");
                        check = false;
                        break;
                    case 5:
                        Console.WriteLine("Kulaklık siparişiniz alınmıştır");
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Tanımsız sipariş numarası girdiniz.Verilen aralıktaki sipariş numaralarından girebilirsiniz.");
                        Console.Write("Sipariş no giriniz (1-5) : ");
                        orderNo = int.Parse(Console.ReadLine());
                        check = true;
                        break;
                }
            }
            while (check);


        }
    }
}
