using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;
using System.ComponentModel.DataAnnotations;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.Extensions.Logging;

namespace Veterinaria.App.Presentacion.Pages
{
   
    public class ClienteModel : PageModel
    {
        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        public String isNombreMascotaValid = "0";
        public IEnumerable<EntidadMascota> listaMascotas;
        
        public EntidadMascota mascotaActual{ get; set; } 



        //guardar cambios
        public String modeForm { get; set; } = "adicion";

        public void OnGet(int id) //se usa en el momento de refrescar la pagina
        {

            id=2;
            if (id != 0){
                this.mascotaActual = repoMascota.GetMascota(id);
                if (this.mascotaActual != null) {
                    Console.WriteLine("NombreMascota" + this.mascotaActual.NombreMascota);
                    if (mascotaActual.Cita== null){
                        EntidadCitas citaF = new EntidadCitas();
                        //citaF.Triage
                        mascotaActual.Cita= citaF;
                        
                    }
                    this.modeForm = "edicion";
                   

                }

            }else{
                this.listaMascotas = repoMascota.GetMascota();

            }
            /*public List <Mascota> listaMascotas= new List<Mascota>( );

            public void OnGet()
            {
                this.listaMascotas.Add(

                   new Mascota {Index= this.listaMascotas.Count+1, NombreMascota = "Molly", FechaNacimiento = new DateTime(2021,06,12), Especie= "Canino", Triage="urgencias", FechaRegistroCitaH= new DateTime(2021,10,15), FechaAtencionCita=new DateTime(2021,10,20)}
                );

                this.listaMascotas.Add(
                   new Mascota {NombreMascota = "Luna", FechaNacimiento= new DateTime(2018,07,12), Especie= "Canino", Triage="Consulta de nutrición", FechaRegistroCitaH= new DateTime(2021,10,16), FechaAtencionCita=new DateTime(2021,10,18)}
                );

                this.listaMascotas.Add(
                   new Mascota  {NombreMascota = "Fiona", FechaNacimiento= new DateTime(2020,12,03), Especie= "Felino", Triage="Desparacitación", FechaRegistroCitaH= new DateTime(2021,10,21), FechaAtencionCita= new DateTime(2021,10,31) }
                );
            }
            public class Mascota{
                public String NombreMascota {get;set;}
                public DateTime FechaNacimiento {get;set;}
                public String Especie {get;set;}
                public String Triage {get;set;}
                public DateTime FechaRegistroCitaH {get;set;}
                public DateTime FechaAtencionCitaH {get;set;}
            }
        }*/

            //CRUD

            

        }
        //Editar
        

        public void OnpostEdit(EntidadMascota mascotaNueva){

            var mascotaEditada = repoMascota.EditarMascota(mascotaNueva);
            if(mascotaEditada != null){
            this.listaMascotas = repoMascota.GetMascota();

                 Console.WriteLine("La mascota ha sido editada");
            }else{
                Console.WriteLine("Ocurrio un errror al editar");
            }
        }
       //Agregar
       public void OnPostAdd(EntidadMascota mascota)
        {
            repoMascota.AgregarMascota(mascota);
            this.listaMascotas = repoMascota.GetMascota();
        }


        //Eliminar
        public void OnPostDelete(int id)
        {
            repoMascota.EliminarMascota(id);
            this.listaMascotas = repoMascota.GetMascota();
        }
    }
}
