using System;

namespace _GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            double f;
            Console.WriteLine("Conversor de Celcius em Fahrenheit");
            Console.WriteLine("informe a temperatura em celcius:");
            C = Convert.ToInt16(Console.ReadLine());
            
            // conversão
            f = C * 1.8 + 32;

            Console.WriteLine("a temperatura em Fahrenheit é " + f);
            
        }
    }
}
