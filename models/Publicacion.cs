using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace POO.Models;
public class Publicacion
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public DateOnly FechaPublicacion { get; set; }


    //Constructor
    public Publicacion(int id, string titulo, DateOnly fechaPublicacion)
    {
        Id = id;
        Titulo = titulo;
        FechaPublicacion = fechaPublicacion;
    }
}