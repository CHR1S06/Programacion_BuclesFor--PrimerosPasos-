using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_BuclesFor.Clases.Apps
{
    public class App3
    {
        // Variable privada para almacenar la suma de los últimos 5 números
        private double SumaUltimos5Dig = 0;

        // Método público que ejecuta el programa principal de la aplicación
        public void Programa3()
        {
            // Limpia la pantalla y muestra el mensaje de bienvenida
            Console.Clear();
            Console.WriteLine("Bienvenido al tercer programa.\n");
            Console.WriteLine("Favor introducir los 10 numeros");

            double Numero;
            for(int i = 1; i <= 10; i++)
            {
                // Solicita al usuario que ingrese el número en la posición actual
                Console.Write($"Favor ingresa el ({i}): ");
                while (true)
                {
                    try
                    {
                        // Lee el número ingresado por el usuario
                        Numero = Convert.ToDouble(Console.ReadLine());
                        break;// Sale del bucle si el número es válido
                    }
                    catch(Exception ex)
                    {
                        // Muestra el mensaje de error si ocurre una excepción
                        Console.WriteLine(ex.Message);
                    }
                }

                // Suma los últimos 5 números ingresados
                if (i > 5 && i <= 10)
                {
                    SumaUltimos5Dig += Numero; 
                }
            }

            // Pausa la ejecución por 5 segundos antes de mostrar el resultado
            Thread.Sleep(5000);
            ComprobacionDeSuma();

            // Muestra un mensaje para volver al menú y espera que el usuario presione una tecla
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();

            // Regresa al menú principal
            Menu.MenuProgram();
        }

        // Método privado para mostrar el resultado de la suma de los últimos 5 números
        private void ComprobacionDeSuma()
        {
            Console.Clear();
            Console.WriteLine($"La suma de los ultimos 5 numeros es: {SumaUltimos5Dig}");
        }
    }
}
