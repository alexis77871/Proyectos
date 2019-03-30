using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Registro.Models
{
    public class Datos
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Cedula { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [Range(15, 50, ErrorMessage = "Debe ser mayor de edad")]
        public int Edad { get; set; }
   
        public int Telefono { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }


        //Nombramos las referencias que usaremos en el ENUM
        public GeneroRef Genero { get; set; }
        public EstadoRef Estado { get; set; }
        public HobbysRef Hobby { get; set; }
    }

    /*  enum es un tipo de datos de tipo de valor.
    La enumeración se utiliza para declarar una lista de constantes enteras nombradas.*/
    public enum GeneroRef
    {
        Masculino,
        Femenino,
        Desconocido
    }
    public enum EstadoRef
    {
        Casado,
        Soltero,
        Viudo,
    }
    public enum HobbysRef
    {
        Televison,
        Deporte,
        Musica,
        Libros

    }
}