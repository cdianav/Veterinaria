using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Veterinaria.App.Presentacion.Pages
{
    public class AdminModel : PageModel
    {
        public List <Veterinario> listaVeterinarios = new List<Veterinario>();

        public void OnGet()
        {
            this.listaVeterinarios.Add(
                   new Veterinario{Index = this.listaVeterinarios.Count+1, Nombre = "Juan", Edad = 30, Telefono = "310", Correo = "Juan@gmail.com"}
            );
            this.listaVeterinarios.Add(
                    new Veterinario{Index = this.listaVeterinarios.Count+1, Nombre = "Pedro", Edad = 30, Telefono = "310", Correo = "Juafn@gmail.com"}
            );
            this.listaVeterinarios.Add(             
                   new Veterinario{Index = this.listaVeterinarios.Count+1, Nombre = "Arturo", Edad = 20, Telefono = "310", Correo = "Jugan@gmail.com"}
            );
            this.listaVeterinarios.Add(
                new Veterinario{Index = this.listaVeterinarios.Count+1, Nombre = "Alejandro", Edad = 50, Telefono = "314", Correo = "Jufffan@gmail.com"}
            );
        }
    }

    public class Veterinario{

        public int Index { get; set; }
        public String Nombre{get; set;}
        public String Telefono{get; set;}
        public int Edad{get; set;}
        public String Correo{get; set;}

    }
}
