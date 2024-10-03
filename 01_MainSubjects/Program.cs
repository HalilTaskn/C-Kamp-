using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları




            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion



            #region StringDeğişkenler

            //string
            //Değişken_Türü Değişken_Adı;



            //string name;
            //name = "Halil ";
            //Console.Write(name);


            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail , district, city;


            customerName = ("Ali");
            customerSurname = ("çakar");
            customerPhone = ("0554255222");
            customerEmail = ("deneme@gmail.com");
            district = ("Karman");
            city = ("İSLAMBOL");

            Console.WriteLine("**** Rezevasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("*******************************************");

            Console.WriteLine();


            customerName = ("Ayşegül");
            customerSurname = ("Kayta");
            customerPhone = ("0554255222");
            customerEmail = ("denemsse@gmail.com");
            district = ("Karmanaman");
            city = ("İSLAMBOL");

            Console.WriteLine("**** Rezevasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("*******************************************");


            #endregion

            #region   Int Değişkenler

            //int number = 61;
            //Console.WriteLine(number);


            int hamburgerPrice = 350;
            int cokePrice = 40;
            int woterPrice = 10;
            int frisePrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 55;
            Console.WriteLine("**** Restoran Menu Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("-----Kola:" + cokePrice + "TL");
            Console.WriteLine("-----SU:" + woterPrice + "TL");
            Console.WriteLine("-----Kızarmalar:" + frisePrice + "TL");
            Console.WriteLine("-----Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata:" + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menu Fiyatı *****");



            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int woterCount;
            int friseCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWoterPrice;
            int totalFrisePrice;
            int totalPizzaPrice;
            int totalLemonedPrice;
            int totalPrice;

            hamburgerCount = 4;
            cokeCount = 4;
            woterCount = 2;
            friseCount = 1;
            pizzaCount = 3;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWoterPrice = woterCount * woterPrice;
            totalFrisePrice = friseCount * frisePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonedPrice = lemonadeCount * lemonadePrice;

            totalPrice = totalHamburgerPrice + totalCokePrice + totalWoterPrice + totalFrisePrice + totalPizzaPrice + totalLemonedPrice;


            Console.WriteLine("*-----------------------");
            Console.WriteLine("Hamburder Tutarı: " + totalHamburgerPrice + " TL ");
            Console.WriteLine("Cola Tutarı: " + totalCokePrice + " TL ");
            Console.WriteLine("Su Tutarı: " + totalWoterPrice + " TL ");
            Console.WriteLine("Kızartma Tutarı: " + totalFrisePrice + " TL ");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL ");
            Console.WriteLine("Limonata Tutarı: " + totalLemonedPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("ToplamTutarı: " + totalPrice + " TL ");






            #endregion


            Console.Read();
        }
    }
}


