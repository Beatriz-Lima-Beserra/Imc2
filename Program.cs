using System;

namespace IMC
{       //Cálculo imc//
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            string idade = Console.ReadLine();

            Console.WriteLine("Informe seu peso:");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe sua alturta:");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Peso: " + peso);
            Console.WriteLine($"Atura: {altura}");

            float result = peso / ( altura * altura );

            if (result <= 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (result >= 18.5 && result < 25.1)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (result >= 25.1)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (result >= 30)
            {
                Console.WriteLine("Obesidade");
            }
                 
        }
    }
}
