using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("String: ");
            string s = Console.ReadLine();

            Console.WriteLine("Caráter: ");
            char carater = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine(" " + texto.Replace(carater, 'x'));
        }
    }
}
