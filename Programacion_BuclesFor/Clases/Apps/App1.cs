using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Programacion_BuclesFor.Clases.Apps
{
    public class App1
    {
        private int LimiteTriangulo = 30;
        private int TriangulosExcedidos = 0;
        private int TriangulosNoExcedidos = 0;

        public void Programa1()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al primer programa.\n");

            Console.Write("Favor ingresar la cantidad de triangulos a calcular: ");
            int CantidadDeTriangulos;
            while (true)
            {
                try
                {
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
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Clear();
            Console.WriteLine("\nPor favor ingrese los datos de los triangulos:");
            double baseTriang;
            double areaTriang;
            for (int i = 1; i <= CantidadDeTriangulos; i++)
            {
                Console.WriteLine($"Triangulo {i}:");
                while(true)
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
                        Console.WriteLine(ex.Message);
                    }
                }

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
                        Console.WriteLine(ex.Message);
                    }
                }

                areaTriang = baseTriang * alturaTriang / 2;
                Console.WriteLine($"El area del triangulo:{areaTriang}\n");

                if (areaTriang > LimiteTriangulo)
                {
                    TriangulosExcedidos++;
                }
                else
                {
                    TriangulosNoExcedidos++;
                }
            }

            Thread.Sleep(5000);
            ComprobacionDeTriangulos();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPara volver al menu presione cualquier tecla");
            Console.ResetColor();
            Console.ReadKey();
            Menu.MenuProgram();
        }

        public void ComprobacionDeTriangulos()
        {
            Console.Clear();
            Console.WriteLine($"Los triangulo que excedieron el limite de area de 30cm son: {TriangulosExcedidos}");
            Console.WriteLine($"Los triangulo que no excedieron el limite de area son: {TriangulosNoExcedidos}");
        }
    }
}
