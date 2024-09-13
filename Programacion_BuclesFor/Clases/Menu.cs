using System;
using System.Collections.Generic;
using System.Text;
using Programacion_BuclesFor.Clases.Apps;
using Programacion_BuclesFor.Clases;

namespace Programacion_BuclesFor.Clases
{
    public class Menu
    {
        public static int RespuestaMenu;
        public static void MenuProgram()
        {
            Console.Clear();
            Console.WriteLine(@"Bienvenido al programa de Programacion Secuencial

1- (App 1) TriangulosConAreaLimite.
2- (App 2) ContadorDivisiblesPor3o5.
3- (App 3) SumaUltimosCinco.
4- Salir del programa");

            Console.Write("\nDigite su respuesta aqui: ");

            while (true)
            {
                try
                {
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    if (RespuestaMenu >= 1 && RespuestaMenu <= 4)
                    {
                        switch (RespuestaMenu)
                        {
                            case 1:
                                App1 app1 = new App1();
                                app1.Programa1();
                                break;

                            case 2:
                                App2 app2 = new App2();
                                app2.Programa2();
                                break;

                            case 3:
                                App3 app3 = new App3();
                                app3.Programa3();
                                break;

                            case 4:
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor limitese a digitar uno de los numeros mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}