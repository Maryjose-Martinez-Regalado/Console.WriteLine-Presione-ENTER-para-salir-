using System;

namespace U2AC2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameUser, password, confirmPassword, title;
            byte cambiar, color, size;

            Console.SetWindowSize(50, 50);

            Console.WriteLine("Ingrese su nombre de usuario:");
            nameUser = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña:");
            password = Console.ReadLine();
            Console.WriteLine("Confirme su contraseña:");
            confirmPassword = Console.ReadLine();

            if (password == confirmPassword)
            {
                Console.WriteLine("Bienvenido a su perfil, {0}.Por favor presione ENTER", nameUser);
                Console.ReadKey();
                Console.WriteLine("\n");
                Console.WriteLine("¿Qué es lo que gustaría cambiar? Presione el número");
                Console.WriteLine("1. Color de la consola, 2. tamaño de la consola, 3. título de la consola");
                cambiar = Convert.ToByte(Console.ReadLine());

                if (cambiar == 2)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Seleccione el tamaño de la consola:");
                    Console.WriteLine("1. paqueño, 2. mediano, 3. grande");
                    size = Convert.ToByte(Console.ReadLine());
                    
                    if (size == 1)
                    {

                        Console.WindowWidth = 50;
                        Console.WindowHeight = 50;

                    }

                    if (size == 2)
                    {

                        Console.WindowWidth = 100;
                        Console.WindowHeight = 100;
                   
                    }

                    if (size == 3)
                    {

                        Console.WindowWidth = 150;
                        Console.WindowHeight = 150;
                       
                    }
                }
                
                if (cambiar == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Seleccione el color:");
                    Console.WriteLine("1. azul, 2. verde, 3. rojo");
                    color = Convert.ToByte(Console.ReadLine());

                    if (color == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                    }

                    if (color == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                    }

                    if (color == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                    }

          
                }
                if (cambiar == 3)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Cambie el título de la consola:");
                    title = Console.ReadLine();
                    Console.Title = title;

                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("ERORR");
                }
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Contraseña incorrecta.");
                
            }
            Console.WriteLine("Presione ENTER para salir");
        }
    }
}