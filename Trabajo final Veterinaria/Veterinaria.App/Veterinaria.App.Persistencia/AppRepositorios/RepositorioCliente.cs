using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepositorioCliente: IRepositorioCliente{

        private readonly AppContext appContext;

        public RepositorioCliente(AppContext appContextParam){

            this.appContext = appContextParam;
        }

        //CRUD

        EntidadCliente IRepositorioCliente.AgregarCliente(EntidadCliente cliente){
            
            var clienteAgregado = this.appContext.Cliente.Add(cliente);
            this.appContext.SaveChanges();            
            return clienteAgregado.Entity;
        }

        EntidadCliente IRepositorioCliente.EditarCliente(EntidadCliente clienteNuevo){
            var clienteEncontrado = this.appContext.Cliente.FirstOrDefault ( p => p.Id == clienteNuevo.Id);

            if(clienteEncontrado != null){
                clienteEncontrado.TipoDocumento = clienteNuevo.TipoDocumento;
                clienteEncontrado.NumeroDocumento = clienteNuevo.NumeroDocumento;
                clienteEncontrado.Nombre = clienteNuevo.Nombre;
                clienteEncontrado.Telefono = clienteNuevo.Telefono;
                clienteEncontrado.Edad = clienteNuevo.Edad;
                clienteEncontrado.Correo = clienteNuevo.Correo;
                clienteEncontrado.Contraseña = clienteNuevo.Contraseña;
                clienteEncontrado.FechaRegistro = clienteNuevo.FechaRegistro;
               clienteEncontrado.listaMisMascotas=clienteNuevo.listaMisMascotas;
                this.appContext.SaveChanges();
                return clienteEncontrado;
            }else{
                return null;
            }

            
        }

        EntidadCliente IRepositorioCliente.GetCliente(int idCliente){
            return this.appContext.Cliente.FirstOrDefault ( p => p.Id == idCliente);
            
        }

        void IRepositorioCliente.EliminarCliente(int idCliente){
            var ClienteEncontrado = this.appContext.Cliente.FirstOrDefault ( p => p.Id == idCliente);
            if(ClienteEncontrado != null){
                this.appContext.Cliente.Remove(ClienteEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadCliente> IRepositorioCliente.GetCliente(){
            return this.appContext.Cliente;
        }

    }

}