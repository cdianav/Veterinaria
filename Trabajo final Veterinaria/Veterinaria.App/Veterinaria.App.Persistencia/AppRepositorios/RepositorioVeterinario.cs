using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepositorioVeterinario: IRepositorioVeterinario{
 
        private readonly AppContext appContext;

        public RepositorioVeterinario(AppContext appContextParam){

            this.appContext = appContextParam;
        }

        //CRUD  

        EntidadVeterinario IRepositorioVeterinario.AgregarVeterinario(EntidadVeterinario veterinario){
            
            var veterinarioAgregado = this.appContext.Veterinarios.Add(veterinario);
            this.appContext.SaveChanges();            
            return veterinarioAgregado.Entity;
        }

        EntidadVeterinario IRepositorioVeterinario.EditarVeterinario(EntidadVeterinario veterinarioNuevo){
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault ( p => p.Id == veterinarioNuevo.Id);

            if(veterinarioEncontrado != null){
                veterinarioEncontrado.TipoDocumento = veterinarioNuevo.TipoDocumento;
                veterinarioEncontrado.NumeroDocumento = veterinarioNuevo.NumeroDocumento;
                veterinarioEncontrado.Nombre = veterinarioNuevo.Nombre;
                veterinarioEncontrado.Telefono = veterinarioNuevo.Telefono;
                veterinarioEncontrado.Edad = veterinarioNuevo.Edad;
                veterinarioEncontrado.Correo = veterinarioNuevo.Correo;
                veterinarioEncontrado.Contraseña = veterinarioNuevo.Contraseña;
                veterinarioEncontrado.FechaRegistro = veterinarioNuevo.FechaRegistro;
                veterinarioEncontrado.TarjetaProfesional = veterinarioNuevo.TarjetaProfesional;
                this.appContext.SaveChanges();
                return veterinarioEncontrado;
            }else{
                return null;
            }

            
        }

        EntidadVeterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario){
            return this.appContext.Veterinarios.FirstOrDefault ( p => p.Id == idVeterinario);
            
        }

        void IRepositorioVeterinario.EliminarVeterinario(int idVeterinario){
            var VeterionarioEncontrado = this.appContext.Veterinarios.FirstOrDefault ( p => p.Id == idVeterinario);
            if(VeterionarioEncontrado != null){
                this.appContext.Veterinarios.Remove(VeterionarioEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadVeterinario> IRepositorioVeterinario.GetVeterinarios(){
            return null;
        }

    }

}

    
