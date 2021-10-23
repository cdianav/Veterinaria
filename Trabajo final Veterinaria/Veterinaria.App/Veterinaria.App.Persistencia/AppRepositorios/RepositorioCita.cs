using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepositorioCita: IRepositorioCita{

        private readonly AppContext appContext;

        public RepositorioCita(AppContext appContextParam){

            this.appContext = appContextParam;
        }

        //CRUD

        EntidadCitas IRepositorioCita.AgregarCita(EntidadCitas citas){
            citas.FechaRegistroCita = DateTime.Now;
            var citaAgregado = this.appContext.Cita.Add(citas);
            this.appContext.SaveChanges();            
            return citaAgregado.Entity;
        }

        EntidadCitas IRepositorioCita.EditarCita(EntidadCitas citaNuevo){
            var citaEncontrado = this.appContext.Cita.FirstOrDefault ( p => p.Id == citaNuevo.Id);

            if(citaEncontrado != null){
                citaEncontrado.Triage = citaNuevo.Triage;
                this.appContext.SaveChanges();
                return citaEncontrado;
            }else{
                return null;
            }

            
        }

        EntidadCitas IRepositorioCita.GetCita(int idCitas){
            return this.appContext.Cita.FirstOrDefault ( p => p.Id == idCitas);
            
        }

        void IRepositorioCita.EliminarCita(int idCitas){
            var CitaEncontrado = this.appContext.Cita.FirstOrDefault ( p => p.Id == idCitas);
            if(CitaEncontrado != null){
                this.appContext.Cita.Remove(CitaEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadCitas> IRepositorioCita.GetCita(){
            return null;
        }

    }

}