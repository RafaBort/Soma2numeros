using System;

namespace Soma2numeros
{
    class Program
    {
        static void Main(string[] args)
        {   
            string numero1;
            string numero2;

            double numero01;
            double numero02;

            double valor;

            Console.WriteLine("Digite um primeiro número....");
            numero1 = Console.ReadLine();
            Console.WriteLine("Digite um segundo...");
            numero2 = Console.ReadLine();

            numero01 = Convert.ToDouble(numero1);
            numero02 = Convert.ToDouble(numero2);
            
            valor = numero01 + numero02;

            Console.WriteLine(valor);


        }
    }
}
