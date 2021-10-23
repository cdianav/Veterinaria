using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioVeterinario{

        EntidadVeterinario AgregarVeterinario(EntidadVeterinario veterinario);
        EntidadVeterinario EditarVeterinario(EntidadVeterinario veterinario);
        EntidadVeterinario GetVeterinario(int idVeterinario);
        void EliminarVeterinario(int idVeterinario);
        IEnumerable <EntidadVeterinario> GetVeterinarios();

    }

}
