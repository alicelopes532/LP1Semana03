using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
             Console.Write("Digite uma string: ");
            string texto = Console.ReadLine() ?? "";

            char caractere;
            while (true)
            {
                Console.Write("Digite um único caráter para substituir: ");
                string entrada = Console.ReadLine();
            
                if (!string.IsNullOrEmpty(entrada) && entrada.Length == 1)
                {
                    caractere = entrada[0];
                    break;
                }
            
                Console.WriteLine("Por favor, digite apenas um único caráter.");
            }

            string resultado = texto.Replace(caractere, 'x');
            Console.WriteLine("String modificada: " + resultado);
        }
    }
}
