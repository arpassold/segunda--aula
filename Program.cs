using System;

namespace segunda__aula
{
    class Program
    {
        static void Main(string[] args)

      

        
        { 
            Console.WriteLine("Qual sua idade?");
          var result = Console.ReadLine();

             //Transformando o texto que o usuário digitou  para um numero
            int userAge = Int32.Parse(result);
          

            // comparando se a idade do usuário é maior que 15 ou menos que 51)
                       
            if(userAge > 15 && userAge < 51)
            {  
                 Console.WriteLine( "sim!Você tem idade para o entra 21");
            }
        //    else if(userAge==14|| userAge==15)
        //     {
        //         //Coparando SE o valor da variavel não for true vai cair aqui                text = "Não! Eu sou menor de idade";
        //         Console.WriteLine( "não, você não tem idade para o entra 21, mas pode ser menor prendiz");
        //          }
           else 
            {
                //Comparando SE o valor da variavel não for true vai cair aqui                text = "Não! Eu sou menor de idade";
                Console.WriteLine( "não, você não tem idade para o entra 21");
            }
            
        }
    }
}
