using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basithesapmakinesi
{
    internal class Program
    {
            static void Main()
            {
                Console.WriteLine("1. sayıyı gir:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2. sayıyı gir:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İşlem seç (+, -, *, /):");
                string islem = Console.ReadLine();

                if (islem == "+")
                {
                    Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                }
                else if (islem == "-")
                {
                    Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
                }
                else if (islem == "*")
                {
                    Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
                }
                else if (islem == "/")
                {
                    Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem");
                }
            }
        }
    }
    

