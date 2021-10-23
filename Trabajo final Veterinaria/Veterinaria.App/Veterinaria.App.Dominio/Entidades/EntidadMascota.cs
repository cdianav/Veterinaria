using System;  
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Veterinaria.App.Dominio
{
    public class EntidadMascota{
        public int Id {get; set;}
        public string NombreMascota {get; set;}
        public DateTime FechaNacimiento {get; set;} //
        public int EdadMascota {get; set;}
        [ForeignKey("Propietario")]     
        public int IdPropietario {get; set;}
        public EntidadCliente Propietario {get; set;}
        public string  Especie {get; set;} 
        public string raza {get; set;}
        public string peso {get; set;}
        [ForeignKey("Cita")]  
        public int? IdCita {get; set;}
        public EntidadCitas Cita {get; set;}
        
        [ForeignKey("HistoriaClinica")]     //relacion de uno a uno
        public int? IdHistoriaClinica {get; set;}
        public EntidadHistoriaClinico HistoriaClinica {get; set;}
        [ForeignKey("Veterinario")] 
        public int? IdVeterinario {get; set;}
        public EntidadVeterinario Veterinario {get; set;}
        public List<EntidadVacuna> listaVacunas {get; set;}
        


    
        
    
        
    }
}