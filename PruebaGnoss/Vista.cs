using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGnoss
{
    public class Vista
    {

        private Proyecto proyecto;

        public Vista()
        {
            proyecto = new Proyecto();

        }

        public void Menu()
        {

            Proyecto Prueba = new Proyecto();

            Console.WriteLine("Introduce la opcion que deseas hacer:");
            Console.WriteLine("1 crear un nuevo proyecto");
            Console.WriteLine("2 para añadir un empleado al proyecto.");
            Console.WriteLine("3 para sacar a un empleado del proyecto.");
            Console.WriteLine("4 para mostrar los empleados.");
            Console.WriteLine("5 para mostrar el proyecto completo.");
            Console.WriteLine("0 para salir.");
            string input = Console.ReadLine();
            int opcion = Int32.Parse(input);

            while (opcion != 0)
            {

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("Introduce el nombre el proyecto");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Introduce el DNI del cliente");
                        input = Console.ReadLine();
                        int dclient = Int32.Parse(input);
                        Dni dni = new Dni(dclient);
                        Console.WriteLine("Introduce el nombre del cliente");
                        string nclient = Console.ReadLine();
                        Console.WriteLine("Introduce los apellidos del cliente");
                        string aclient = Console.ReadLine();
                        Console.WriteLine("Introduce la fecha de nacimiento del cliente");
                        string fclient = Console.ReadLine();                     
                        Console.WriteLine("Introduce el id del cliente");
                        input = Console.ReadLine();
                        int idclient = Int32.Parse(input);
                        Console.WriteLine("Introduce el presupuesto del cliente");
                        input = Console.ReadLine();
                        double pclient = double.Parse(input);
                        Cliente client = new Cliente(dni, nclient, aclient, fclient, dclient, pclient);
                        Prueba = new Proyecto(nombre, client);

                        break;
                    case 2:

                        Console.WriteLine("Introduce el número de empledo encargado");
                        input = Console.ReadLine();
                        int demple = Int32.Parse(input);
                        dni = new Dni(demple);
                        Console.WriteLine("Introduce el nombre del empledo encargado");
                        string nemple = Console.ReadLine();
                        Console.WriteLine("Introduce los apellidos del empledo encargado");
                        string aemple = Console.ReadLine();
                        Console.WriteLine("Introduce la fecha de nacimiento del empledo encargado");
                        string femple = Console.ReadLine();
                        Console.WriteLine("Introduce el departamento del empledo encargado");
                        string depemple = Console.ReadLine();
                        Console.WriteLine("Introduce el salario del empledo encargado");
                        input = Console.ReadLine();
                        double semple = double.Parse(input);
                        Empleado emple = new Empleado(dni, nemple, aemple, femple, depemple, semple);
                        Prueba.Anadir(emple);

                        break;
                    case 3:
                        Console.WriteLine("Introduce el número de DNI del empleado a sacar del proyecto");
                        input = Console.ReadLine();
                        dni = new Dni(Int32.Parse(input));
                        Prueba.Borrar(dni);

                        break;
                    case 4:

                        Prueba.Mostrar();


                        break;
                    case 5:

                        Prueba.MostrarAula();

                        break;

                    default:
                        Console.WriteLine("No has introducido una opción válida");
                        break;
                }

                Console.WriteLine("Introduce la opcion que deseas hacer:");
                Console.WriteLine("1 crear un nuevo proyecto");
                Console.WriteLine("2 para añadir un empleado al proyecto.");
                Console.WriteLine("3 para sacar a un empleado del proyecto.");
                Console.WriteLine("4 para mostrar los empleados.");
                Console.WriteLine("5 para mostrar el proyecto completo.");
                Console.WriteLine("0 para salir.");
                input = Console.ReadLine();
            opcion = Int32.Parse(input);
            }

            Console.WriteLine("¡Gracias por usar nuestra aplicación!");


        }

    }


}



