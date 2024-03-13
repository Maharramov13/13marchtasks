internal class Program
{
    public static void Main(string[] args)
    {
       int[]ededler=new int[5];
       for(int i=0;i<5;i++)
       {
        System.Console.WriteLine("Ededleri daxil edin");
        ededler[i]=Convert.ToInt16(Console.ReadLine());
       

       }
        Array.Sort(ededler);
        foreach(int i in ededler)
        {
            Console.WriteLine(i);
        }
        Console.Read();
    }
}