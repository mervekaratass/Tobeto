using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Question6
    {
        //String metotlarını araştırınız. Her bir metot için örnek yapınız.

        public void GetStringMethods()
        {
            // Length: Bir string metnin uzunluğunu döndürür.
            string text = "Merhaba";
            int length = text.Length;
            Console.WriteLine("Metnin uzunluğu: " + length);


            //ToUpper: Bir metnin tüm karakterlerini büyük harfe dönüştürür.
            string text2 = "merhaba";
            string upperText = text2.ToUpper();
            Console.WriteLine("Büyük harfe dönüştürülmüş hali: " + upperText);



            // ToLower: Bir metnin tüm karakterlerini küçük harfe dönüştürür.
            string text3 = "MERHABA";
            string lowerText = text3.ToLower();
            Console.WriteLine("Küçük harfe dönüştürülmüş hali: " + lowerText);

            //Trim: Bir metnin başındaki ve sonundaki boşlukları kaldırır.
            string text4 = "   Merhaba   ";
            string trimmedText = text4.Trim();
            Console.WriteLine("Boşlukları kaldırılmış hali: " + trimmedText);

            //Substring: Belirtilen başlangıç konumundan başlayarak bir alt metni döndürür.
            string text5 = "Merhaba Dünya";
            string subText = text5.Substring(8, 3);// başlama indeksi ve uzunluğu
            string subText2 = text5.Substring(8);// başlama indeksi
            Console.WriteLine("Alt dizgi: " + subText);
            Console.WriteLine("Alt dizgi2: " + subText2);

            //Contains: Bir metnin belirli bir karakter metni içerip içermediğini kontrol eder.
            string text6 = "Merhaba Dünya";
            bool contains = text6.Contains("Dünya"); //true fale değeri döndürür
            Console.WriteLine("Dizgi içeriyor mu? " + contains);

            //Replace: Belirli bir karakter dizisini başka bir karakter dizisiyle değiştirir.
            string text7 = "Merhaba Dünya";
            string newText = text7.Replace("Dünya", "Mars");
            Console.WriteLine("Yeni dizgi: " + newText);

            //IndexOf: Belirtilen bir karakter dizisinin dizginin içindeki konumunu bulur.
            string text8 = "Merhaba Dünya";
            int index = text8.IndexOf('a', 8); //8 . indeksten aramaya başlar 
            int index2 = text8.IndexOf('a'); // ilk a yı bulur  
            Console.WriteLine("Konum: " + index);
            Console.WriteLine("Konum2: " + index2);

            //Remove: Bir metinden belirtilen bir karakter dizisini veya karakterlerin bir alt kümesini kaldırır.
            string text9 = "Merhaba Dünya";
            string removeText = text9.Remove(3, 5); // 3. indeksten başlayarak 5 karakteri kaldırır
            string removeText2 = text9.Remove(3); // 3. indeksten başlayarak hepsini kaldırır.
            Console.WriteLine("Yeni dizgi: " + removeText);
            Console.WriteLine("Yeni dizgi2: " + removeText2);


            //Split: Bir metni belirli bir ayırıcı karaktere göre böler ve alt metinlerin bir dizisini döndürür.
            string text10 = "Merhaba,Dünya,Nasılsınız";
            string[] parts = text10.Split(",");

            Console.WriteLine("Bölünmüş metinler:");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }

            //Burda istersek tekrar birleştirme işlemi yapabilriz.
            string joinedText = string.Join(" ", parts); // Ayırıcı olarak boşluk kullanıldı

            Console.WriteLine("Birleştirilmiş metin:");
            Console.WriteLine(joinedText);
        }
    }
}
