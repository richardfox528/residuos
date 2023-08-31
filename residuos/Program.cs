using System;

namespace residuos
{
    internal class Program
    {
        static int div = 10;
        private static string validate;
        private static int num;
        private static bool isNum;

        static void Main(string[] args)
        {
            Console.Title = "Residuos.";
            
            do
            {
                Console.Write("Ingrese un numero de cinco digitos: ");
                validate = Console.ReadLine();
                isNum = int.TryParse(validate, out num);
                Console.ForegroundColor = ConsoleColor.Red;
            } while (!isNum || num <= 9999 || num > 99999);

            Console.ResetColor();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine( $"El numero {num} dividido por {div} es igual a {num / div}. Su residuo es {num % div}");
                div = div * 10;
            }
        }
    }
}