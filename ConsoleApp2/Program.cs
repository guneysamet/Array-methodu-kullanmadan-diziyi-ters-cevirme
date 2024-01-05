using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Diziniz kaç elemanlı olsun : ");
            int eleman = Convert.ToInt32(Console.ReadLine());
            int[] dizi1 =new int[eleman];
            Console.WriteLine();
            for (int i = 0; i < eleman; i++)
            {
                Console.Write("Dizinin {0}. elemanını giriniz : ",i+1);
                dizi1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Diziniz : ");
            for (int i = 0; i < eleman; i++)
            {
                Console.Write(dizi1[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Dizinizin tersi : ");
            for (int i = eleman-1; i >= 0; i--)
            {
                Console.Write(dizi1[i] + " ");
            }
            Console.Read();
        }
    }
}
