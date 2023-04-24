using System;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();

           var meuArray = new int[5] { 1, 2, 3, 4, 5 };
           meuArray[0] = 12;

           for (var index = 0; index <= meuArray.Length; index++)
           {
               Console.WriteLine((meuArray[index]));
           }

           foreach (var item in meuArray)
           {
               Console.WriteLine(item);
           }
           

               
          
        }
    }
}