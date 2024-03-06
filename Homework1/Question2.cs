using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Question2
    {
        //kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.
        //(Input için Scanner ve döngü için for döngüsü kullanınız)
        public void GetShopTotalPrice()
        {

            Console.WriteLine("Kaç ürün almak istiyorsunuz ?");
            int amount = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < amount; i++)
            {
                Console.Write("Ürünün fiyati:");
                total += int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Toplam tutar :" + total);
        }
    }
}
