using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double number;

            //number = 4.61;

            //Console.WriteLine(number);


            #region Double Değişkenler


            //Console.WriteLine("***** FİYAT LİSTESİ ****");
            //Console.WriteLine();


            //double applePrice, orangePrice, strawbarryPrice, tomatoPrice, potatoPrice;


            //applePrice = 14.23;
            //orangePrice = 12.42;
            //strawbarryPrice =15.2;
            //tomatoPrice = 16.55;
            //potatoPrice = 46.21;






            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawbarryPrice + "TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + "TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + "TL");



            //double appleGram , orangeGram , strawbarryGram, tomatoGram , potatoGram ;

            //appleGram = 1.235;
            //orangeGram = 3.412;
            //strawbarryGram = 1.423;
            //tomatoGram = 2.533;
            //potatoGram = 3.452;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawbarryGram * strawbarryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoGram;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Toplam Elma Tutarı " + appleTotalPrice);
            //Console.WriteLine("Toplam Elma Tutarı "+ orangeTotalPrice);
            //Console.WriteLine("Toplam Elma Tutarı "+ strawTotalPrice);
            //Console.WriteLine("Toplam Elma Tutarı "+ appleTotalPrice);
            //Console.WriteLine("Toplam Elma Tutarı "+ tomatoTotalPrice);

            #endregion




            #region Char Değişkenler
            // char yazarken tek tırnak kullanmamız egerekir Şift + 2 ile '' gibi




            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);










            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler


            //Console.WriteLine("***************** CSharp Hava Yolları Yolcu Bilgisi ******* ");
            //Console.WriteLine();


            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdenityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();


            //Console.Write("Yolcu Soyadı: ");

            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik");
            //passengerIdenityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict 
            //    + " " + passengerCity + " " + passengerAge + " " + passengerIdenityNumber);








            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 1344;
            //tvPrice = 13000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız Ayakkabı Adedini Giriniz ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Adedi Giriniz");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Adedi Giriniz");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Adedi Giriniz");
            //tvCount = int.Parse(Console.ReadLine());



            //int totalPrice=shoeCount*shoePrice + computerCount*computerCount + chairCount*chairCount + tvCount*tvPrice;


            //Console.WriteLine();
            //Console.WriteLine("TOPLAM Ödenmesi Gereken Miktar: " + totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 =double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);



            #endregion


            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " +gender);

            #endregion






















            Console.Read();

        }
    }
}
