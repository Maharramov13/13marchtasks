using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static void Main(string[] args)
    {
        string[] words={"Baki", "Azerbaycanin","paytaxtidir"};
        char symbol='y';
       SimvolVarmi(words,symbol);
       
    }
    
        static void SimvolVarmi(string[] words,char symbol)
        {
            foreach(var item in words){
                if(IsContain(item,symbol)){
                   Console.WriteLine(item); 
                }
            }
        }   

        static  bool IsContain(string str,char chr){
            foreach (var item in str)
            {
                if(item==chr){
                    return true;
                }  
            }
             
            return false;
        }

}