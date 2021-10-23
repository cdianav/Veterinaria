using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepositorioMascota: IRepositorioMascota{

        private readonly AppContext appContext;

        public RepositorioMascota(AppContext appContextParam){

            this.appContext = appContextParam;
        }

        //CRUD

        EntidadMascota IRepositorioMascota.AgregarMascota(EntidadMascota mascota){
            
            var mascotaAgregado = this.appContext.Mascota.Add(mascota);
            this.appContext.SaveChanges();            
            return mascotaAgregado.Entity;
        }

        EntidadMascota IRepositorioMascota.EditarMascota(EntidadMascota mascotaNuevo){
            var mascotaEncontrado = this.appContext.Mascota.FirstOrDefault ( p => p.Id == mascotaNuevo.Id);

            if(mascotaEncontrado != null){
                mascotaEncontrado.NombreMascota = mascotaNuevo.NombreMascota !=null? mascotaNuevo.NombreMascota : mascotaEncontrado.NombreMascota;
                mascotaEncontrado.FechaNacimiento = mascotaNuevo.FechaNacimiento !=null? mascotaNuevo.FechaNacimiento : mascotaEncontrado.FechaNacimiento;
                mascotaEncontrado.EdadMascota = mascotaNuevo.EdadMascota;
                mascotaEncontrado.Especie = mascotaNuevo.Especie;
                mascotaEncontrado.raza = mascotaNuevo.raza;
                mascotaEncontrado.peso = mascotaNuevo.peso;
                this.appContext.SaveChanges();
                return mascotaEncontrado;
            }else{
                return null;
            }

            
        }

        EntidadMascota IRepositorioMascota.GetMascota(int idMascota){
            return this.appContext.Mascota.FirstOrDefault ( p => p.Id == idMascota);
            
        }

        void IRepositorioMascota.EliminarMascota(int idMascota){
            var MascotaEncontrada = this.appContext.Mascota.FirstOrDefault ( p => p.Id == idMascota);
            if(MascotaEncontrada != null){
                this.appContext.Mascota.Remove(MascotaEncontrada);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadMascota> IRepositorioMascota.GetMascota(){
            return this.appContext.Mascota;
        }


    }

}