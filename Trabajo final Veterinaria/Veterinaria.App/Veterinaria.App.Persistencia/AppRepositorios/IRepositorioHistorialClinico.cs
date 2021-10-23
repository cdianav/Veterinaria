using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioHistorialClinico{

        EntidadHistoriaClinico AgregarHistoriaClinico(EntidadHistoriaClinico historialClinico);
        EntidadHistoriaClinico EditarHistoriaClinico(EntidadHistoriaClinico historialClinico);
        EntidadHistoriaClinico GetHistoriaClinico(int idHistoriaClinico);
        void EliminarHistoriaClinico(int idHistoriaClinico);
        IEnumerable <EntidadHistoriaClinico> GetHistoriaClinico();
        

    }

}
