using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5._0Kalitim
{
    class Insan
    {


        public Insan()
        {

            Console.WriteLine("Insan yapıcı metot u çalıştı.");
        }
        public string TcKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        //Internal ifadesi musterinin kalıtım alması sonucu  musteri üzerinden örnekleme yaptığımızda ulaşabilmemizi sağlar.
        //Internal ifadesi kullanmaz isek  protected olduğu takdirde sadece kalıtım aldığımız class ın içerisnde kullanabiliriz.
        protected internal void EkranaYaz()
        {


            Console.WriteLine("{0}-{1}",this.Ad,this.Soyad);


        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}-{3}", this.TcKimlikNo, this.Ad, this.Soyad,
                this.DogumTarihi.ToShortDateString());
        }
    }
}
