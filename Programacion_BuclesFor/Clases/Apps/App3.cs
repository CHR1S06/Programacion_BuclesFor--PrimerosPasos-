using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_BuclesFor.Clases.Apps
{
    public class App3
    {
        private double SumaUltimos5Dig = 0;
        public void Programa3()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al tercer programa.\n");
            Console.WriteLine("Favor introducir los 10 numeros");

            double Numero;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write($"Favor ingresa el ({i}): ");
                while (true)
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

                if(i > 5 && i <= 10)
                {
                    SumaUltimos5Dig += Numero; 
                }
            }

            Thread.Sleep(5000);
            ComprobacionDeSuma();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }

        private void ComprobacionDeSuma()
        {
            Console.Clear();
            Console.WriteLine($"La suma de los ultimos 5 numeros es: {SumaUltimos5Dig}");
        }
    }
}
