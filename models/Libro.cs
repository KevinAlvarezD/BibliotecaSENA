using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Libro : Publicacion
    {
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }
        public double Precio { get; set; }

        // Constructor
        public Libro(int id, string titulo, DateOnly fechaPublicacion, string autor, string isbn, string genero, double precio)
        : base(id, titulo, fechaPublicacion)
        {
            Autor = autor;
            ISBN = isbn;
            Genero = genero;
            Precio = precio;
        }



        public  void Descripcion()
        {
           Console.WriteLine($"Id: {Id} | Fecha de Publicacion: {FechaPublicacion} | Titulo: {Titulo} | ISBN: {ISBN} | Genero: {Genero} | Precio: {Precio}");
        }
        }

    }
