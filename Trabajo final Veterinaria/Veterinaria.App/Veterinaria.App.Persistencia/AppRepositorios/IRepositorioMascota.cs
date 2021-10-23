using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioMascota{

        EntidadMascota AgregarMascota(EntidadMascota mascota);
        EntidadMascota EditarMascota(EntidadMascota mascota);
        EntidadMascota GetMascota(int idMascota);
        void EliminarMascota(int idMascota);
        IEnumerable <EntidadMascota> GetMascota();
        

    }

}
