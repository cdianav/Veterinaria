using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioVacuna{

        EntidadVacuna AgregarVacuna(EntidadVacuna vacuna);
        EntidadVacuna EditarVacuna(EntidadVacuna vacuna);
        EntidadVacuna GetVacuna(int idVacuna);
        void EliminarVacuna(int idVacuna);
        IEnumerable <EntidadVacuna> GetVacuna();
        

    }

}
