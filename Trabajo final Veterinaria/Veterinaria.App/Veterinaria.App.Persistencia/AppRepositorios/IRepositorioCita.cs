using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioCita{

        EntidadCitas AgregarCita(EntidadCitas citas);
        EntidadCitas EditarCita(EntidadCitas citas);
        EntidadCitas GetCita(int idCitas);
        void EliminarCita(int idCitas);
        IEnumerable <EntidadCitas> GetCita();
        

    }

}
