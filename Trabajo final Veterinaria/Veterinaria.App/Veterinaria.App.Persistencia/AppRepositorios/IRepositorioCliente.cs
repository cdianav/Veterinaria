using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioCliente{

        EntidadCliente AgregarCliente(EntidadCliente cliente);
        EntidadCliente EditarCliente(EntidadCliente cliente);
        EntidadCliente GetCliente(int idCliente);
        void EliminarCliente(int idCliente);
        IEnumerable <EntidadCliente> GetCliente();
        

    }

}
