//#define Kullanim1
#define Kullanim2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_base_kullanımı
{


#if (Kullanim1)



    class Kitap
    {
        public void Ad()
        {
            Console.WriteLine("kitap adı");
        }

    }

    class Roman:Kitap
    {
        public void IsnbNO() 
        {
            base.Ad();
            Console.WriteLine("Isbo no");

             

        }
    }

    class RomanDetay:Roman
    {
        public void SayfaNo()
        {
            base.IsnbNO();
            Console.WriteLine("sayfa no");

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            RomanDetay romanDetay = new RomanDetay();
            romanDetay.SayfaNo();

            //Roman roman = new Roman();
            //roman.IsnbNO();

            Console.ReadKey();



        }
    }



#elif (Kullanim2)

    class Kitap
    {
        public Kitap()
        {
            Console.WriteLine("kitap adı:OD");
        }

        public Kitap(string adi)
        {
            Console.WriteLine("kitap adı"+adi);
        }




    }

    class Roman : Kitap
    {

        public Roman() :base ()
        {
            Console.WriteLine("ISBN  No :123");
        }

        public Roman(string isbnno) :base (isbnno)
        {
            Console.WriteLine("isbenno adı" + isbnno);

        }

    }


   

        class Program
        {
            static void Main(string[] args)
            {

            Roman roman = new Roman();

           //Roman roman1 = new Roman("132");








                Console.ReadKey();



            }
        }


#endif

}
