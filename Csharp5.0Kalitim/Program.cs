using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5._0Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Musteri M1=new Musteri();

            Personel P1=new Personel();
            M1.Ad = "John";
            M1.Soyad = "doe";

            M1.KuponKod = "ABC";

            M1.DogumTarihi = DateTime.Parse("12.02.1984");


            M1.TcKimlikNo = "111111111111";

            //M1.MUsteriKuponKullan();

            //M1.EkranaYaz();


            //personel

            //Personel P1 = new Personel()
            //{
            //    Ad = "halil",
            //    Soyad = "vatan",
            //    DogumTarihi = DateTime.Parse("12.12.1912"),
            //    SicilNo = "1111",
            //    TcKimlikNo = "11111111111111"


            //};


            //object O1 = M1;
            //object O2 = P1;

            //Insan I1 = M1;
            //Musteri M4 = (Musteri) I1;


            Console.ReadLine();


        }
    }
}
