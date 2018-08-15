using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp5._2Abstract
{
    class Program
    {
        static void Main(string[] args)
        {

            Turk T1=new Turk();

            T1.Dil = "Türkçe";

            T1.Konus();


            Console.ReadLine();


        }
    }
    //ınsan sınıfı abstract bir sınıf olduğu için içinde bulunan abstract terimli her değişkeni ve metot u kendi içerisinde barındırmak zorundadır.
    //Abstract sınıflardan nesne üretemezsin.
    abstract class Insan
    {


        public abstract string Dil { get; set; }
      

        public abstract void Konus();
    }

    class Turk : Insan
    {

      
        public override string Dil { get; set; }
        public override void Konus()
        {
            Console.WriteLine("{0} dilini konuşuyor.",Dil);
        }
    }
}
