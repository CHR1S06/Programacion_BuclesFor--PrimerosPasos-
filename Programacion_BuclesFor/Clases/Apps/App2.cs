using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_BuclesFor.Clases.Apps
{
    public class App2
    {
        private int LimiteDeNumeros = 10;
        private int DivisiblePor3 = 0;
        private int DivisiblePor5 = 0;
        private int NoDivisiblePor3 = 0;
        private int NoDivisiblePor5 = 0;

        public void Programa2()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al segundo programa.\n");

            Console.WriteLine("Ahora va a introducir diez numeros.");
            double Numero;
            for(int i = 1; i <= LimiteDeNumeros; i++)
            {
                Console.Write($"Favor introducir el ({i}) numero: ");
                while(true)
                {
                    try
                    {
                        Numero = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (Numero % 3 == 0)
                {
                    DivisiblePor3++;
                }
                if (Numero % 5 == 0)
                {
                    DivisiblePor5++;
                }
                if (Numero % 3 != 0)
                {
                    NoDivisiblePor3++;
                }
                if (Numero % 5 != 0)
                {
                    NoDivisiblePor5++;
                }
            }

            Thread.Sleep(5000);
            ComprobacionDivisExacta();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }

        private void ComprobacionDivisExacta()
        {
            Console.Clear();
            Console.WriteLine($"Los numeros divisibles por 3 son: {DivisiblePor3}");
            Console.WriteLine($"Los numeros divisibles por 5 son: {DivisiblePor5}");
            Console.WriteLine($"Los numeros que no son divisibles por 3 son: {NoDivisiblePor3}");
            Console.WriteLine($"Los numeros que no son divisibles por 5 son: {NoDivisiblePor5}");
        }
    }
}
