using System;

namespace Extention
{
    class Program
    {
        static void Main(string[] args)
        {
           
                #region 
                int reqem;
                do
                {
                    Console.WriteLine("Reqem daxil edin");
                    reqem = Convert.ToInt32(Console.ReadLine());
                }
                while (reqem == 0);
                Console.WriteLine($"Tekdir? - {reqem.IsOdd()}");

                int reqem2;
                do
                {
                    Console.WriteLine("Reqem daxil edin");
                    reqem2 = Convert.ToInt32(Console.ReadLine());
                }
                while (reqem2 == 0);
                Console.WriteLine($"Cutdur? - {reqem2.IsEven()}");

                string text1;
                do
                {
                    Console.WriteLine("Metn daxil edin");
                    text1 = Console.ReadLine();
                }
                while (string.IsNullOrWhiteSpace(text1));
                Console.WriteLine($"Metn daxilinde reqem varmi?: {text1.IsContainsDigit()}");

                string text2;
                do
                {
                    Console.WriteLine("Metn daxil edin");
                    text2 = Console.ReadLine();
                }
                while (string.IsNullOrWhiteSpace(text2));
                Console.WriteLine(text2.ToCapitalize());

                string text3;
                do
                {
                    Console.WriteLine("Metn daxil edin");
                    text3 = Console.ReadLine();
                }
                while (string.IsNullOrWhiteSpace(text3));
                char digit = 'u';
                int[] arrayindex = text3.GetValueIndexes(digit);
                foreach (var item in arrayindex)
                {
                    Console.WriteLine(item);
                }
                #endregion
            }
        }
    }
