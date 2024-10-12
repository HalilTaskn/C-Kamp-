using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];

            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Mavi";
            //colors[3] = "Mor";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Türkiye";
            //cities[2] = "İslambol";

            //int[] numbers = new int[10];

            //numbers[0] = 60;
            //numbers[1] = 25;
            //numbers[2] = 23;
            //numbers[3] = 3555;
            //numbers[8] = 235;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "prag", "roma", "bursa" };

            //Console.WriteLine(cities[0]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme



            //string[] colors = { "sarı", "pembe", "mor", "borda", "kırmızı" };

            //for (int i = 0; i < colors.Length; i++)
            //{

            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };


            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] %3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }


            //}

            //char[] symbols = { 'A', 'b', 'c', 'd', 'e' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    if (symbols[i] == 'A')
            //    {
            //        Console.WriteLine("YOU DİD İT");
            //    }
            //}

            //int[] myArray = { 32, 54, 73, 75, 23, 995, 43, 55, 13, 965, 123, 434 };

            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "mehmet", "aişe" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 14, 23, 123, 41, 32, 515, 634, 43, 41 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 14, 23, 123, 41, 32, 515, 634, 43, 41 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Methotları

            //string[] custemers = { "ali", "mehmet", "ahmet", "ayşe" };
            //int index = Array.IndexOf(custemers, "mehmet");
            //Console.WriteLine(index);

            //int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, };

            //Console.WriteLine("Dizinin Enbuyuk Elemanı: " + numberArray.Max() + "Dizinin Enküçük Elemanı: " + numberArray.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //Console.Write($"Lütfen {i + 1}. Şehri Giriniz:  ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("----------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 13, 21, 32, 51, 12 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //int[] numbers = { 21, 32, 43, 54, 65, 76, 87, 98,  19, 210 };
            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %2 == 0)
            //    {  Console.WriteLine(numbers[i]); }
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------");

            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    { Console.WriteLine(numbers[i]); }
            //}

            #endregion



            Console.Read();
        }
    }
}
