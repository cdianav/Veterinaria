using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;


namespace Veterinaria.App.Presentacion.Pages
{

    public class RegistroModel : PageModel
    {
        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        public EntidadCliente Propietario;
        public EntidadMascota Mascota;
        [BindProperty]
        public bool IsChecked { get; set; }
        public void OnGet()
        {
            Propietario = new EntidadCliente();
            Propietario.Edad = null;
            Mascota = new EntidadMascota();

        }
        public void OnPost(EntidadCliente propietario, EntidadMascota mascota)
        {
           
            Console.WriteLine(IsChecked);
            if (IsChecked)
            {


                EntidadCliente MiPropietario = new EntidadCliente();
                EntidadMascota Mimascota = new EntidadMascota();
                MiPropietario = repoCliente.AgregarCliente(propietario);
                //mascota.Propietario = MiPropietario;
                mascota.IdPropietario = MiPropietario.Id;
                Mimascota = repoMascota.AgregarMascota(mascota);
                if (Mimascota != null)
                {
                    List<EntidadMascota> listaMMascotas = new List<EntidadMascota>();
                    listaMMascotas.Add(Mimascota);
                    MiPropietario.listaMisMascotas = listaMMascotas;
                    repoCliente.EditarCliente(MiPropietario);
                    Response.Redirect("../Login/Login"); //redirecciona despues de hacer el registro
                }

            }else{
                Console.WriteLine("No se marco");
            }
        }

    }
}

