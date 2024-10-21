using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //()
            // Geriye değer döndürmeyen metotlar
            //Custemer--> Listele, ekle , sil , güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ahmet Gülmez");
            //    Console.WriteLine("Ayşe Sağlam");
            //    Console.WriteLine("Mehmet Şaşmaz");

            //}
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customername)
            //{
            //    Console.WriteLine(customername);
            //}

            //WriteMethod("ahmet şafak");


            //void CustomerCard(string name , string surName )
            //{
            //    Console.WriteLine("Mşteri: " + name + " " + surName);
            //}
            //CustomerCard("Ahmet", "Gülmez");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum(int number1 , int number2 , int number3)
            //{
            //    int result = number1 + number2 + number3;
            //   Console.WriteLine(result);
            //}
            //sum(2, 5, 6);


            #endregion


            #region Geriye Değer Döndüren Metotlar


            //string CustomerName()
            //{
            //    return " Buse Yıldız";
            //}

            //CustomerName(); 

            //string studentCard()
            //{
            //    string name = "Ahmet";
            //    string surname = "Yıldız";

            //    return name + " " + surname;

            //}
            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //    string CountryCard(string countryName , string capital , string flagColor)
            //    {
            //        string cardInfo= "Ülke: + " + countryName +" Başkent:  "+ capital + "  Bayrak Rengi: "+ flagColor;
            //        return cardInfo;
            //    }

            //    string x,y,z;
            //    Console.Write("Ülke Adını Giriniz: ");
            //    x = Console.ReadLine();

            //    Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //    Console.Write("Bayrak Rengini Giriniz: ");
            //    z= Console.ReadLine();

            //    Console.WriteLine(x,y,z);

            //    Console.WriteLine("Türkiye", "Ankara", "Al - Ak");

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int sum(int number1 , int number2) 
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(sum(21, 32));
            //Console.WriteLine(sum(221, 352));
            //Console.WriteLine(sum(216, 52));


            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + "Öğrenci Geçti : " + result;
            //    }
            //    else
            //    {
            //        return student + "Öğrenci Kladı: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ahmet", 12, 53, 34));
            #endregion

            Console.Read();
        }
    }
}
