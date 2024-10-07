using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region     if   else

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");

            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "istanbul" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğru");
            //}
            //else
            //{
            //    Console.Write("Veriler Yanlış");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else {
            //    Console.WriteLine("Yanlış");
            //}

            //int exam1 , exam2 , exam3,average ;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 =int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) /3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";

            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";

            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";

            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "antep" | city == "urfa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir İçerir");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir İçermez");
            //}

            //Console.Write("Kullanıcı Adınız Giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Yanlış Kullanıcı Adı");
            //}
            //else
            //{
            //    Console.WriteLine("Doğru Giriş Yaptınız");
            //}
            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);  

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayınının 2. sayıya bölümünden kalan " + result);




            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else {
            //    Console.Write("Sayı Tektir");
            //}


            #endregion


            #region Char Değişkenleri ile Karar yapıları
            //Console.Write("Lütfen Takımınızı Seçiniz");

            //char team = char.Parse(Console.ReadLine());
            //if (team == 'F' | team == 'f')
            //{
            //    Console.Write("feneer");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.Write("TRABZONSPORT");
            //}

            //if (team == 'R' | team == 'r')
            //{
            //    Console.Write("rizespore");
            //}


            #endregion

            #region Örnek Proje Uygulama

            //Console.WriteLine("******* C# Eğitim Kampı Restorant *******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Lütfen Numara Seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("--------Ana Yemekler--------");
            //    Console.WriteLine("1-Şiş Kebap");
            //    Console.WriteLine("2-Tavuk Kebap");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("--------İçecekler--------");
            //    Console.WriteLine("1-AYRAN");
            //    Console.WriteLine("2-SU");
            //}
            // if (menuItem == "3")
            //{
            //    Console.WriteLine("--------Tatlılar--------");
            //    Console.WriteLine("1-Katmer");
            //    Console.WriteLine("2-Kadayıf");
            //}
            #endregion

            #region Switch Case 

            //Console.WriteLine("Lütfen Ay Girişi Yapınız");
            //int montNumber = int.Parse(Console.ReadLine()); 


            //switch (montNumber)
            //{
            //    case 1 : Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;

            //    default:Console.WriteLine("Hatalı Numara");
            //        break ;
            //}




            #endregion

            #region Switch Case Hesap Makinesi



            //int number1, number2 ,result;
            //char symbol;

            //Console.WriteLine("1.Sayıyı Giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.WriteLine("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yapmak İstadiğiniz İşlemi Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma : " + result);
            //        break;
            //    case '*':
            //        result = number1 *  number2;
            //        Console.WriteLine("Çarpma : " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme : " + result);
            //        break;

            //        default:Console.WriteLine("Hatalı sembol girildi");
            //        break;
            //}
            #endregion
            Console.Read();          
        }
    }
}
