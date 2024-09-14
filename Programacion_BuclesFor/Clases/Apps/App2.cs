using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_BuclesFor.Clases.Apps
{
    public class App2
    {
        // Variables privadas para contar los números según su divisibilidad
        private int LimiteDeNumeros = 10;
        private int DivisiblePor3 = 0;
        private int DivisiblePor5 = 0;
        private int NoDivisiblePor3 = 0;
        private int NoDivisiblePor5 = 0;

        // Método público que ejecuta el programa principal de la aplicación
        public void Programa2()
        {
            // Limpia la pantalla y muestra el mensaje de bienvenida
            Console.Clear();
            Console.WriteLine("Bienvenido al segundo programa.\n");

            // Informa al usuario que introducirá diez números
            Console.WriteLine("Ahora va a introducir diez numeros.");
            double Numero;
            for(int i = 1; i <= LimiteDeNumeros; i++)
            {
                // Solicita al usuario que ingrese el número en la posición actual
                Console.Write($"Favor introducir el ({i}) numero: ");
                while(true)
                {
                    try
                    {
                        // Lee el número ingresado por el usuario
                        Numero = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch(Exception ex)
                    {
                        // Muestra el mensaje de error si ocurre una excepción
                        Console.WriteLine(ex.Message);
                    }
                }

                // Verifica si el número es divisible por 3
                if (Numero % 3 == 0)
                {
                    DivisiblePor3++;
                }
                // Verifica si el número es divisible por 5
                if (Numero % 5 == 0)
                {
                    DivisiblePor5++;
                }
                // Verifica si el número no es divisible por 3
                if (Numero % 3 != 0)
                {
                    NoDivisiblePor3++;
                }
                // Verifica si el número no es divisible por 5
                if (Numero % 5 != 0)
                {
                    NoDivisiblePor5++;
                }
            }

            // Pausa la ejecución por 5 segundos antes de mostrar el resumen
            Thread.Sleep(5000);
            ComprobacionDivisExacta();

            // Muestra un mensaje para volver al menú y espera que el usuario presione una tecla
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();

            // Regresa al menú principal
            Menu.MenuProgram();
        }

        // Método privado para mostrar el resumen de la divisibilidad de los números ingresados
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
