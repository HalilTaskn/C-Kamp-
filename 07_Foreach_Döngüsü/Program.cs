using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste,Koleksiyon,Dizi


            //string[] cities = { "milano", "roma", "ankara", "istanbul", "muş" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 1, 25, 687, 95, 47, 5121, 356, 475, 85 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 1, 2, 586, 6985, 4512, 58, 221, 35687, 4515, 6545678, 5224 };

            //foreach (int i in numbers)
            //{
            //    if(i %2 == 0)
            //    {  
            //        Console.WriteLine(i);
            //    }

            //}

            //int[] numbers = { 1, 2, 586, 6985, 4512, 58, 221, 35687, 4515, 6545678, 5224 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //string word = "merhaba";

            //foreach (char i in word)
            //{
            //    Console.WriteLine(i);
            //}





            #endregion


            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("**** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            
            
            //Sınıftan öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("---------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentName = new string[studentCount];
            double[] studentExamAvg =new double[studentCount];  

            for(int i=0; i<studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;


                //Her Öğrenci İçin 3 sınav notu girişi


                for (int k = 0; k < 3 ; k++)
                {
                    Console.Write($"{studentName[i]} isimkli öğrencinin {k + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//Notları Topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3 ;

            }
            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("----------------------");

                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}" );
                
                // Öğrencilerin ortalaması ve geçip kalma durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı");

                }

                Console.WriteLine("----------------------") ;
            }





            #endregion

            Console.Read();


        }
    }
}
