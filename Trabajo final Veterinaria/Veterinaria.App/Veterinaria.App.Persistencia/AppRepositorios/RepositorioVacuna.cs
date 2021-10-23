using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia{

    public class RepositorioVacuna: IRepositorioVacuna{

        private readonly AppContext appContext;

        public RepositorioVacuna(AppContext appContextParam){

            this.appContext = appContextParam;
        }

        //CRUD

        EntidadVacuna IRepositorioVacuna.AgregarVacuna(EntidadVacuna vacuna){
            
            var vacunaAgregado = this.appContext.Vacuna.Add(vacuna);
            this.appContext.SaveChanges();            
            return vacunaAgregado.Entity;
        }


        EntidadVacuna IRepositorioVacuna.EditarVacuna(EntidadVacuna vacunaNueva){
            var vacunaEncontrada = this.appContext.Vacuna.FirstOrDefault ( p => p.Id == vacunaNueva.Id);

            if(vacunaEncontrada != null){
                vacunaEncontrada.NombreVacunaObligatoria = vacunaNueva.NombreVacunaObligatoria;
                vacunaEncontrada.NombreVacunaComplementaria = vacunaNueva.NombreVacunaComplementaria;
                this.appContext.SaveChanges();
                return vacunaEncontrada;
            }else{
                return null;
            }

            
        }

        EntidadVacuna IRepositorioVacuna.GetVacuna(int idVacuna){
            return this.appContext.Vacuna.FirstOrDefault ( p => p.Id == idVacuna);
            
        }

        void IRepositorioVacuna.EliminarVacuna(int idVacuna){
            var VacunaEncontrada = this.appContext.Vacuna.FirstOrDefault ( p => p.Id == idVacuna);
            if(VacunaEncontrada != null){
                this.appContext.Vacuna.Remove(VacunaEncontrada);
                this.appContext.SaveChanges();
            }
        }

        IEnumerable <EntidadVacuna> IRepositorioVacuna.GetVacuna(){
            return null;
        }


    }

}