using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5._0Kalitim
{//Insan dan Musteri kalıttı Musteri Insanı base olarak kullanır.
    //Musteriden örnekleme yapıldığında Burada musteri içersinde bulunan tanımlamalar dışında Insan içindeki Tanımlamalarada erişilebilir.
    //Burda anlaşılacağı gibi soldaki sağdan kalıtım alır .kalıtım alınan class kalıtım alan class ın içindekilere erişemez.
    class Musteri:Insan
    {


        public string MusteriNumarasi { get; set; }

        public string KuponKod { get; set; }



        public Musteri()
        {
            Console.WriteLine("Musteri yapıcı metot çalıştı.");
        }
        public void MUsteriKuponKullan()
        {


            Console.WriteLine("kupon kullanıldı");
        }
    }
}
