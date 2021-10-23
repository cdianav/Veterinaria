using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace Veterinaria.App.Dominio
{
    public class EntidadVeterinario: EntidadPersona{
        public String Especializacion {get; set;}
        public String TarjetaProfesional {get; set;}
        
        public List<EntidadMascota> listaMascotas {get; set;}


         
    }
}
