using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5._1SanalMetot
{
    class Insan
    {

        public string Adi { get; set; }
        public string Soyad { get; set; }

        public int Cinsiyet { get; set; }
        public string Dil { get; set; }
        protected internal virtual void Konus()
        {


            Console.WriteLine("Insan için dil atanmadı");
        }

    }

    class Turk:Insan
    {

        //Virtual yani sanal metotlar overrrida metotu ile ezilebilir.
        protected internal override void Konus()
        {
            //base.Konus();


            Console.WriteLine("Dil olarak {0} konuşuyor.",Dil);
        }
    }

    class Ingiliz : Insan
    {
        //buraya da ıngiliz için ayırt edici ortak olmayan değşkenler yazılabilir.

        //Virtual yani sanal metotlar overrrida metotu ile ezilebilir.Örneklenen sınıf içerisindeki override metotu ile ezer ve istenilen işlemi yapar.
        protected internal override void Konus()
        {
            //base.Konus();


            Console.WriteLine("Dil olarak {0} konuşuyor.", Dil);
        }
    }
}
