using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5._0Kalitim
{
    class Personel:Insan
    {
        public Personel()
        {


            Console.WriteLine("Personel yapıcı metot çalıştı.");
                
        }

        public string SicilNo { get; set; }

        public void PersonelGirisCikis()
        {

            Console.WriteLine("Pdks sistemine girisi sağlandı.");
        }
    }
}
