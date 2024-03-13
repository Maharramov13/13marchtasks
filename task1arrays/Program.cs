using System.Globalization;
using System.Reflection.Metadata;

internal class Program
{
    public static void Main(string[] args)
    {
//         
int sort;
int[] sayilar = new int[5] { 3, 9, 12, 1, 7 };
Console.Write("Duzulushun ilk hali: ");
foreach (int items in sayilar)
{
            Console.Write(items + " ");           
}
for (int i = 0; i < sayilar.Length-1; i++)
{
            for (int j = i; j < sayilar.Length; j++)
            {
            
                        if (sayilar[i] > sayilar[j])                                              
                        {
                                     sort= sayilar[j];
                                    sayilar[j] = sayilar[i];
                                    sayilar[i] = sort;
                        }

            }

}
Console.WriteLine();
Console.Write("Duzulushun son hali: ");
foreach (int items in sayilar)
{
            Console.Write(items + " ");
}
Console.ReadKey();
    }
}