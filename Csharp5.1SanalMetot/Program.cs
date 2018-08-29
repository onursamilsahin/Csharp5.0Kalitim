using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5._1SanalMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan K1=new Insan();
             //Burada ınsan için dil atanamadı yani başka bir class içerisinde örneklenmediği zaman Default çalışıyor.
            //Ancak örnekleme yapıldığında sanal metot ezilerek işlem istenilen class üzerinden yapılıyor.
            K1.Konus();
            Turk T1=new Turk();


            T1.Adi = "john";
            T1.Soyad = "doe";
            T1.Cinsiyet = 1;
            T1.Dil = "Türkçe";

            T1.Konus();



            Ingiliz I1=new Ingiliz();

            I1.Adi = "deneme";
            I1.Dil = "ingilizce";
            I1.Konus();
            
            Console.ReadLine();


        }
    }
}
