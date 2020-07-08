using System;

namespace segunda__aula
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var myBoolean= true;

            Console.WriteLine("Você é maior de idade?");
            var result = Console.ReadLine();

            myBoolean = result== "sim";
            Console.WriteLine(myBoolean );
            
        }
    }
}
