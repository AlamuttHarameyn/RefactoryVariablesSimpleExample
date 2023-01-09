using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11._1_KarakterDizilimleri
{
    class Refactory_BasitDegiskenOrnegi
    {
        static void Main(string[] args)
        {
            //Kodu iyileştirmeye refactory denir.
            //hızlı işlemler adlı menüden bu işlemleri kolayca yapabiliriz
            //örneğin kodu methoda dönüştürmek için kullanabiliriz.
            //kodu  methoda çevirmek için ctrl+. tuşlarına basarak küçük bir menü açıp ardından
            //extract methodu seçiyoruz.yeniden adlandırıyoruz.kodumuzu methoda çevrildi.

            int sayi = 2;
            Console.WriteLine(sayi); //Sayi 2 demek
            Console.WriteLine(sayi + 2); //sayiya 2 ekle
            Console.WriteLine(sayi * sayi); //sayiyi sayiyla carp
            Console.WriteLine(sayi - 5); //sayidan 5 çıkar

            Console.ReadKey();
        }
    }
}
