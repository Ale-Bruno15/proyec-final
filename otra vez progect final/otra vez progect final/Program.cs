using System;
// Alejandro Bruno 2019-8666
namespace otra_vez_progect_final
{
    class Program
    {
        static void Main(string[] args)
        {

            string usur;   //usur1 123-1234567-5,  usur2 123-1234568-6,  usur3 123-1234569-7   usur4 111-1234567-1
            int clave;     //clave1 1234,          clave2 1235,          clave3 1236           Clave4 1237
            string salir;

            DateTime creacion = new DateTime(2015, 7, 25, 8, 30, 15);
            DateTime creacion2 = new DateTime(2007, 9, 10, 5, 15, 00);
            DateTime creacion3 = new DateTime(2010, 3, 9, 6, 10, 20);

            do
            {
                Console.Clear();
                Console.WriteLine("pulse enter para empezar");
                salir = Console.ReadLine();

                Console.Write("Digite el usuario: ");
                usur = Console.ReadLine();

                if (usur == "123-1234567-5") 
                {
                    do
                    {
                        Console.Write("Digite la clave: ");
                        clave = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nClave incorrecta, intetelo otra vez.");

                    } while (clave != 1234);
                    Console.Clear();

                    Console.WriteLine("Bienvenido, Alejandro Bruno \n \n Haz ingresado con el usuario: " + usur + "\n Estado: Activo \n Rol en la empresa: Supervisor \n Fecha de creacion: "+ creacion.ToString("MM/dd/yyyy hh:mm:ss") +"\n \n Pulse s para salir y digitar otro usuario \n Pulse enter para cerrar programa");
                    salir = Console.ReadLine();
                }

               else if (usur == "123-1234568-6")
                {
                    do
                    {
                        Console.Write("Digite la clave: ");
                        clave = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nClave incorrecta, intetelo otra vez.");

                    } while (clave != 1235);
                    Console.Clear();

                    Console.WriteLine("Bienvenido, Antonio Perez \n \n Acabas de ingresar con el usuario: " + usur + "\n Estado: Activo \n Rol en la empresa: Adminitrador \n Fecha de creacion: " + creacion2.ToString("MM/dd/yyyy hh:mm:ss") + "\n \n Pulse s para salir y digitar otro usuario \n Pulse enter para cerrar programa");
                    
                    salir = Console.ReadLine();
                }
               else if (usur == "111-1234567-1")
                {
                    do
                    {
                        Console.Write("Digite la clave: ");
                        clave = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nclave incorrecta, intetelo otra vez.");
                    } while (clave != 1237);
                    Console.Clear();
                    Console.WriteLine("Bienvenido, Guzman Peralta \n \n Acabas de ingresar con el usuario: " + usur + "\n Estado: Activo \n Rol en la empresa: Vendedor \n Fecha de creacion: " + creacion3.ToString("MM/dd/yyyy hh:mm:ss") + "\n \n Pulse s para salir y digitar otro usuario \n Pulse enter para cerrar programa");
                    
                    salir = Console.ReadLine();
                }
              else if (usur=="123-1234569-7")
              {
                    do
                    {
                        Console.Write("Digite la clave");
                        clave = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nClave incorrecta, intetelo otra vez.");

                    } while (clave != 1236);
                    Console.Clear();

                    Console.WriteLine("Este usuaio esta inactivo \n \n pulse s para salir y validad a otro \n Pulse enter para cerrar el programa");
                    salir = Console.ReadLine();
              }
                else
                {
                    Console.WriteLine("El usuario es incorrecto \n \n Pulse s para salir e intentar de nuevo\n Pulse enter para cerrar y finalizar");
                    salir = Console.ReadLine();
                }
                if (salir =="")
                {
                    Console.Clear();
                    Console.WriteLine("Cerraste el programa");
                    break;
                }
            } while (salir == "s" || salir == "S");
        }
    }
}
