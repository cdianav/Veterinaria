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
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        public String isNombreMascotaValid = "0";
        public IEnumerable<EntidadMascota> listaMascotas;
        
        public EntidadCliente clienteActual{ get; set; } 
        public EntidadMascota mascotaActual{ get; set; } 


        //guardar cambios
        public String modeForm { get; set; } = "adicion";

        public void OnGet(int id) //se usa en el momento de refrescar la pagina
        {

            id=4;
            if (id != 0){
                this.clienteActual = repoCliente.GetCliente(id);
                if (this.clienteActual != null) {
                    listaMascotas = clienteActual.listaMisMascotas;
                    mascotaActual=new EntidadMascota();
                    mascotaActual.Cita=new EntidadCitas();

                   // Console.WriteLine("NombreMascota" + this.clienteActual.NombreMascota);
                   /* if (clienteActual.Cita== null){
                        EntidadCitas citaF = new EntidadCitas();
                        //citaF.Triage
                        clienteActual.Cita= citaF;
                        
                    }*/
                    this.modeForm = "edicion";
                   

                }

            }else{
              //  this.listaMascotas = repoCliente.GetCliente();

            }
           
            //CRUD

            

        }
        //Editar
        

        public void OnpostEdit(EntidadMascota mascotaNueva){

          /*  var mascotaEditada = repoCliente.EditarCliente(mascotaNueva);
            if(mascotaEditada != null){
            this.listaMascotas = repoCliente.GetCliente();

                 Console.WriteLine("La mascota ha sido editada");
            }else{
                Console.WriteLine("Ocurrio un errror al editar");
            }
        }
       //Agregar
       public void OnPostAdd(EntidadMascota mascota)
        {
            repoCliente.AgregarMascota(mascota);
            this.listaMascotas = repoCliente.GetMascota();
        }


        //Eliminar
        public void OnPostDelete(int id)
        {
            repoCliente.EliminarMascota(id);
            this.listaMascotas = repoCliente.GetMascota();
        }*/
    }
}
}
