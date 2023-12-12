using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı.");
            Kisi k = new Kisi();
            Console.WriteLine("Adı: {0}",k.Ad);
            Console.WriteLine("Yaşı: {0}", k.Yas);
            Console.WriteLine("Program bitti");
        }
        class Kisi
        {
            int yas;
            string ad;
            public Kisi()
            {
                yas = 18;
                ad = "Ahmet";
                Console.WriteLine("Yapıcı metot çalıştı.");
            }
            public int Yas
            {
                get 
                {
                    return yas;
                }
            }
            public string Ad
            { 
                get 
                { 
                    return ad;
                }
            }
        }
    }
}
