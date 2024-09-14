using System;
using System.Collections.Generic;
using System.Text;
using Programacion_BuclesFor.Clases.Apps;
using Programacion_BuclesFor.Clases;

namespace Programacion_BuclesFor.Clases
{
    public class Menu
    {
        // Variable estática para almacenar la opción seleccionada en el menú
        public static int RespuestaMenu;

        // Método estático que muestra el menú y maneja la selección del usuario
        public static void MenuProgram()
        {
            // Limpia la consola y muestra el menú principal
            Console.Clear();
            Console.WriteLine(@"Bienvenido al programa de Programacion Secuencial

1- (App 1) TriangulosConAreaLimite.
2- (App 2) ContadorDivisiblesPor3o5.
3- (App 3) SumaUltimosCinco.
4- Salir del programa");

            // Pide al usuario que ingrese su selección
            Console.Write("\nDigite su respuesta aqui: ");

            // Bucle para validar la selección del usuario
            while (true)
            {
                try
                {
                    // Lee la opción seleccionada por el usuario
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    // Verifica si la opción está dentro del rango permitido
                    if (RespuestaMenu >= 1 && RespuestaMenu <= 4)
                    {
                        // Ejecuta el programa correspondiente basado en la selección del usuario
                        switch (RespuestaMenu)
                        {
                            case 1:
                                // Crea una instancia de App1 y llama al método Programa1
                                App1 app1 = new App1();
                                app1.Programa1();
                                break;

                            case 2:
                                // Crea una instancia de App2 y llama al método Programa2
                                App2 app2 = new App2();
                                app2.Programa2();
                                break;

                            case 3:
                                // Crea una instancia de App3 y llama al método Programa3
                                App3 app3 = new App3();
                                app3.Programa3();
                                break;

                            case 4:
                                // Opción para salir del programa, no hace nada
                                break;
                        }
                        break;// Sale del bucle después de ejecutar la opción seleccionada
                    }
                    else
                    {
                        // Mensaje de error si la opción ingresada no es válida
                        Console.WriteLine("Por favor limitese a digitar uno de los numeros mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    // Muestra el mensaje de error si ocurre una excepción
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}