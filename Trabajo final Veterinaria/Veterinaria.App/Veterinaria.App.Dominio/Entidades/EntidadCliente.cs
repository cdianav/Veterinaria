using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Veterinaria.App.Dominio
{
    public class EntidadCliente: EntidadPersona{
        public List<EntidadMascota> listaMisMascotas {get; set;}
         
    }
}
