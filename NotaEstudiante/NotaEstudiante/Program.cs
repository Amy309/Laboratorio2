// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using NotaEstudiante.Models;
using NotaEstudiante.DAO;

CrudNota CrudNota = new CrudNota();
Notum Notum = new Notum();

    Console.WriteLine("Menu");
    Console.WriteLine("1) Calcular Notas");
    Console.WriteLine("2) Listar");
    var menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 1:
        bool bucle = true;
        while (bucle == true)
        {
                Console.WriteLine("Ingresa tu nombre\n");
                Notum.NombreEstudiante = Console.ReadLine();
                Console.WriteLine("Ingresa la materia\n");
                Notum.Materia = Console.ReadLine();
                Console.Write("\nIngrese la nota del Lab1\n");
                Notum.Lab1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\nIngrese la nota del Parcial1\n");
                Notum.Parcial1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\nIngrese la nota del Lab2\n");
                Notum.Lab2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\nIngrese la nota del Parcial2\n");
                Notum.Parcial2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\nIngrese la nota del Lab3\n");
                Notum.Lab3 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\nIngrese la nota del Parcial3\n");
                Notum.Parcial3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Su resultado es {CrudNota.Total(Notum)}");
            CrudNota.AgregarNota(Notum);

            Console.Write("Su nota fue almacenada correctamente\n");
            Console.Write("Presione 2 para salir\n");

            var Menu2 = Convert.ToInt32(Console.ReadLine());

            switch (Menu2)
            {
                case 1:
                    bucle = true;
                    break;

                case 2:
                    Console.Write("Gracias por utilizar el programa");
                    bucle = false;
                    break;

                default:
                    Console.Write("");
                    break;
            }
        }
        break;

    case 2:
        Console.Write("Gracias por utilizar el programa");
        break;

    default:
        Console.Write("");
        break;

    }