using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;


namespace POO.Models;


public class Program
{
        static void Main(string[] args)
    {
        MostrarMenu();
    }
    static void MostrarMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=========================================================================");
            Console.WriteLine("                            BIBLIOTECA  SENA                             ");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("| {0,-1} | {1,-43} |", " No ", "                           Opción                             ");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(1) ", "Añadir Nuevo Libro                                            ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(2) ", "Clasificacion de lo Libros                                    ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(3) ", "Buscar Libro                                                  ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(4) ", "Informacion de Libro                                          ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(5) ", "                                                              ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(6) ", "                                                              ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(7) ", "                                                              ");
            Console.WriteLine("| {0,-1} | {1,-53} |", "(0) ", "Salir                                                         ");
            Console.WriteLine("=========================================================================");
            Console.Write("Seleccione una opción del menú: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.WriteLine("UPS!! OPCION INVALIDA, INTENTE DE NUEVO...");
                Thread.Sleep(4000); // Espera 4 segundos antes de volver al menú
                continue;
            }

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Gracias por utilizar nuestra biblioteca SENA. Hasta pronto!");
                    Environment.Exit(0);
                    break;
                case 1:
                    Functions.AñadirLibro();
                    break;
                case 2:
                    Functions.ClasificacionDeLibros();
                    break;
                case 3:
                    Functions.BuscarLibro();
                    break;
                case 4:
                    Functions.MostrarDescripcion(); 
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine();
        }
    }





}