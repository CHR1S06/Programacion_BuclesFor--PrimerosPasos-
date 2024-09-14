using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_BuclesFor.Clases.Apps
{
    public class App1
    {
        // Variables privadas para almacenar el límite de área y los contadores de triángulos
        private int LimiteTriangulo = 30;
        private int TriangulosExcedidos = 0;
        private int TriangulosNoExcedidos = 0;

        // Método público que ejecuta el programa principal de la aplicación
        public void Programa1()
        {
            // Limpia la pantalla y muestra el mensaje de bienvenida
            Console.Clear();
            Console.WriteLine("Bienvenido al primer programa.\n");

            // Solicita al usuario la cantidad de triángulos a calcular
            Console.Write("Favor ingresar la cantidad de triangulos a calcular: ");
            int CantidadDeTriangulos;
            while (true)
            {
                try
                {
                    // Lee la cantidad de triángulos y verifica que sea un número positivo
                    CantidadDeTriangulos = Convert.ToInt32(Console.ReadLine());
                    if(CantidadDeTriangulos > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese una cantidad valida.");
                    }
                }
                catch(Exception ex)
                {
                    // Muestra el mensaje de error si ocurre una excepción
                    Console.WriteLine(ex.Message);
                }
            }

            // Limpia la pantalla y pide los datos para cada triángulo
            Console.Clear();
            Console.WriteLine("\nPor favor ingrese los datos de los triangulos:");
            double baseTriang;
            double areaTriang;
            for (int i = 1; i <= CantidadDeTriangulos; i++)
            {
                Console.WriteLine($"Triangulo {i}:");

                // Solicita la base del triángulo y valida que sea un número positivo
                while (true)
                {
                    try
                    {
                        Console.Write("Base: ");
                        baseTriang = Convert.ToDouble(Console.ReadLine());
                        if(baseTriang > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Por favor limitese a introducir una cantidad valida.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Muestra el mensaje de error si ocurre una excepción
                        Console.WriteLine(ex.Message);
                    }
                }

                // Solicita la altura del triángulo y valida que sea un número positivo
                Console.Write("");//salto de linea
                double alturaTriang;
                while (true)
                {
                    try
                    {
                        Console.Write("Altura: ");
                        alturaTriang = Convert.ToDouble(Console.ReadLine());
                        if (alturaTriang > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Por favor limitese a introducir una cantidad valida.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Muestra el mensaje de error si ocurre una excepción
                        Console.WriteLine(ex.Message);
                    }
                }

                // Calcula el área del triángulo
                areaTriang = baseTriang * alturaTriang / 2;
                Console.WriteLine($"El area del triangulo:{areaTriang}\n");

                // Contabiliza el triángulo según su área
                if (areaTriang > LimiteTriangulo)
                {
                    TriangulosExcedidos++;
                }
                else
                {
                    TriangulosNoExcedidos++;
                }
            }

            // Pausa la ejecución por 5 segundos antes de mostrar el resumen
            Thread.Sleep(5000);
            ComprobacionDeTriangulos();

            // Muestra un mensaje para volver al menú y espera que el usuario presione una tecla
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();

            // Regresa al menú principal
            Menu.MenuProgram();
        }

        // Método para mostrar el resumen de los triángulos procesados
        public void ComprobacionDeTriangulos()
        {
            Console.Clear();
            Console.WriteLine($"Los triangulo que excedieron el limite de area de 30cm son: {TriangulosExcedidos}");
            Console.WriteLine($"Los triangulo que no excedieron el limite de area son: {TriangulosNoExcedidos}");
        }
    }
}
