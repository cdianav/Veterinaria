using System;  
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinaria.App.Dominio
{
    public class EntidadVacuna{
        
        public int Id {get; set;}
        public String NombreVacunaObligatoria {get; set;}
        public String NombreVacunaComplementaria {get; set;}
        public DateTime FechaRegistroVacuna {get; set;}
        [ForeignKey("Mascota")]    
        public int idMascota {get; set;}
        public EntidadMascota Mascota {get; set;} 
       
}
}