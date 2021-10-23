using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Veterinaria.App.Dominio
{
    public class EntidadCitas{
        public int Id {get; set;}
        public DateTime FechaRegistroCita {get; set;}
        public DateTime FechaAtencionCita {get; set;}
        public bool Estado {get; set;}
        public String Triage {get; set;}
        
       
   
    }
    
}