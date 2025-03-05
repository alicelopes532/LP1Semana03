using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
             Console.Write("String: ");
            string texto = Console.ReadLine() ?? "";

            Console.Write("Caráter: ");
            char caractere = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            string resultado = texto.Replace(caractere, 'x');
            Console.WriteLine("String modificada: " + resultado);
        }
    }
}
