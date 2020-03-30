using System;

namespace projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int PriNumero, SegNumero, Soma;

            Console.WriteLine("Digite o primeiro numero");
            PriNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite o segundo numero");
            SegNumero = Convert.ToInt32(Console.ReadLine());

            Soma = PriNumero + SegNumero;

            Console.WriteLine("A soma de dois" +Soma);
            Console.WriteLine("Por favor Patrick pressione qualquer teclado para sair de programa!....");
            Console.ReadKey();


        }
    }
}
