using System.Globalization;
using System.Runtime.CompilerServices;

internal class Program
{
     static void Main(string[] args)
    {   //3.Array revers yöntemine uyğun CustomReverse(int[] arr) yöntemini yazın.
        Console.WriteLine("ededleri daxil edin: ");

            int[] ededler = new int[5];
 
            for (int i = 0; i < ededler.Length; i++)
            {
                Console.Write("siralamanin " + (i + 1) + ". ededini girin: ");
                ededler[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Girilen ededlerin tersten yazilishi");
            for (int i = (ededler.Length-1); i >= 0; i--)
            {
                Console.WriteLine("Tersten siralamanin " + (ededler.Length - i) + " . ededi = " + ededler[i]);
            }
            Console.ReadLine();

    }
    
}