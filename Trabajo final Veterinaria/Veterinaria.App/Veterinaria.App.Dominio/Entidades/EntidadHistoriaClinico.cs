using System;  
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Veterinaria.App.Dominio
{
    public class EntidadHistoriaClinico{
        public int Id {get; set;}
        public DateTime FechaRegistroCitaH {get; set;}
        public DateTime FechaAtencionCitaH {get; set;}
        public String Diagnostico {get; set;}
       public List<EntidadCitas> listaCitas {get; set;}
       
        
    }
}