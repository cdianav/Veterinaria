using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepositorioHistorialClinico: IRepositorioHistorialClinico{

        private readonly AppContext appContext;

        public RepositorioHistorialClinico(AppContext appContextParam){

            this.appContext = appContextParam;
        }

        //CRUD

        EntidadHistoriaClinico IRepositorioHistorialClinico.AgregarHistoriaClinico(EntidadHistoriaClinico historialClinico){
            
            var historialClinicoAgregado = this.appContext.HistorialClinico.Add(historialClinico);
            this.appContext.SaveChanges();            
            return historialClinicoAgregado.Entity;
        }

        EntidadHistoriaClinico IRepositorioHistorialClinico.EditarHistoriaClinico(EntidadHistoriaClinico historialClinicoNuevo){
            var historialClinicoEncontrado = this.appContext.HistorialClinico.FirstOrDefault ( p => p.Id == historialClinicoNuevo.Id);

            if(historialClinicoEncontrado != null){
                historialClinicoEncontrado.Diagnostico = historialClinicoNuevo.Diagnostico;
                this.appContext.SaveChanges();
                return historialClinicoEncontrado;
            }else{
                return null;
            }

            
        }

        EntidadHistoriaClinico IRepositorioHistorialClinico.GetHistoriaClinico(int idHistoriaClinico){
            return this.appContext.HistorialClinico.FirstOrDefault ( p => p.Id == idHistoriaClinico);
            
        }

        void IRepositorioHistorialClinico.EliminarHistoriaClinico(int idHistoriaClinico){
            var HistorialClinicoEncontrado = this.appContext.HistorialClinico.FirstOrDefault ( p => p.Id == idHistoriaClinico);
            if(HistorialClinicoEncontrado != null){
                this.appContext.HistorialClinico.Remove(HistorialClinicoEncontrado);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadHistoriaClinico> IRepositorioHistorialClinico.GetHistoriaClinico(){
            return null;
        }

    }

}