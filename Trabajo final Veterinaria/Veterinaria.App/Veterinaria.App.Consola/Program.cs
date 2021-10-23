using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;
namespace Veterinaria.App.Consola
{
    class Program
    {
        private static IRepositorioVeterinario repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // -------->CRUD CLIENTE<---------

            //AgregarCliente();
            //EditarCliente(1);
            //BuscarCliente(1);
            //EliminarCliente(1);



            // -------->CRUD VETERINARIO<---------

            //AgregarVeterinario();
            //EditarVeterinario(2);
            //BuscarVeterinario (4);
            //EliminarVeterinario(1);


            // -------->CRUD MASCOTA<---------

            //AgregarMascota();
            //EditarMascota(1);
            //BuscarMascota(1);
            //EliminarMascota(3);

            // -------->CRUD VACUNA<---------

            //AgregarVacuna();
            //EditarVacuna(1);
            //BuscarVacuna(1);
            //EliminarVacuna(1);

            // -------->CRUD HISTORIALCLINICO<---------

            //AgregarHistoriaClinico();
            //EditarHistoriaClinico(1);
            //BuscarHistoriaClinico(1);
            //EliminarHistoriaClinico(1);

            // -------->CRUD Cita<---------

            //AgregarCita();
            //EditarCita(1);
            //BuscarCita(1);
            //EliminarCita(1);
            
        }
        /*
        
        

        private static void AgregarVeterinario(){

            EntidadVeterinario veterinario = new EntidadVeterinario{
                TipoDocumento = "CC",
                NumeroDocumento = "65532",
                Nombre = "Diana",
                Telefono = "2222222",
                Edad = 28,
                Correo = "Diana@gmail.com",
                Contraseña = " fffsfs",
                FechaRegistro = new DateTime(2021,01,14),
                Especializacion = "TEFSD",
                TarjetaProfesional = " sfsdfs"

            };

            repoVeterinario.AgregarVeterinario(veterinario);

        }

        private static void EditarVeterinario(int idVeterinario){
            EntidadVeterinario veterinario = new EntidadVeterinario{
                Id = idVeterinario,
                TipoDocumento = "CE",
                NumeroDocumento ="66872",
                Nombre = "Tatiana",
                Telefono = "4335",
                Edad = 15,
                Correo = "PRUEBA@GMAIL.COM",
                Contraseña = "PRUEBA",
                FechaRegistro = new DateTime(2021,01,14),
                Especializacion = "PRUEBA",
                TarjetaProfesional = "PRUEBA"
            };
        repoVeterinario.EditarVeterinario(veterinario);
        }

        private static void BuscarVeterinario(int idVeterinario){

            var veterinarioEncontrado = repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine("El nombre del veterionario es: "+veterinarioEncontrado.Nombre);

        }

        private static void EliminarVeterinario(int idVeterinario){
            repoVeterinario.EliminarVeterinario(idVeterinario);
        }

        //-------------------Cliente---------------------

        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AppContext());

        private static void AgregarCliente(){

            EntidadCliente cliente = new EntidadCliente{

                TipoDocumento = "CC",
                NumeroDocumento = "65532",
                Nombre = "Diana",
                Telefono = "2222222",
                Edad = 28,
                Correo = "Diana@gmail.com",
                Contraseña = " fffsfs",
                FechaRegistro = new DateTime(2021,01,14)
                

            };

            repoCliente.AgregarCliente(cliente);

        }

        private static void EditarCliente(int idCliente){
            EntidadCliente cliente = new EntidadCliente{
                Id = idCliente,
                TipoDocumento = "CE",
                NumeroDocumento ="66872",
                Nombre = "Tatiana",
                Telefono = "4335",
                Edad = 15,
                Correo = "PRUEBA@GMAIL.COM",
                Contraseña = "PRUEBA",
                FechaRegistro = new DateTime(2021,01,14)
            };
        repoCliente.EditarCliente(cliente);
        }

        private static void BuscarCliente(int idCliente){

            var clienteEncontrado = repoCliente.GetCliente(idCliente);
            Console.WriteLine("El nombre del cliente es: "+clienteEncontrado.Nombre);

        }

        private static void EliminarCliente(int idCliente){
            repoCliente.EliminarCliente(idCliente);
        }
        

        //-------------------Mascota---------------------

        private static IRepositorioMascota repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        private static void AgregarMascota(){

            EntidadMascota mascota = new EntidadMascota{

                NombreMascota = "Max",
                FechaNacimiento = new DateTime(2021,01,14),
                EdadMascota = 6,
                IdPropietario = 1,
                Especie = "Gato",
                raza = "Criollo",
                peso = "20 kg"

            };

            repoMascota.AgregarMascota(mascota);
            

        }

        private static void EditarMascota(int idMascota){
            EntidadMascota mascota = new EntidadMascota{
                Id = idMascota,
                NombreMascota = "Rolly",
                FechaNacimiento = new DateTime(2011,01,14),
                EdadMascota = 15,
                Especie = "Perro",
                raza = "Perza",
                peso = "50 kg"
            };
        repoMascota.EditarMascota(mascota);
        }

        private static void BuscarMascota(int idMascota){

            var mascotaEncontrada = repoMascota.GetMascota(idMascota);
            Console.WriteLine("La edad es: : "+mascotaEncontrada.EdadMascota);

        }

        private static void EliminarMascota(int idMascota){
            repoMascota.EliminarMascota(idMascota);
        }

        //-------------------Vacuna---------------------

        private static IRepositorioVacuna repoVacuna = new RepositorioVacuna(new Persistencia.AppContext());

        private static void AgregarVacuna(){

            EntidadVacuna vacuna = new EntidadVacuna{

                NombreVacuna = "Varicela",
                TipoVacuna = "Intramuescular",
                FechaRegistroVacuna = new DateTime(2021,05,14)
                

            };

            repoVacuna.AgregarVacuna(vacuna);
            
        }
        
        private static void EditarVacuna(int idVacuna){
            EntidadVacuna vacuna = new EntidadVacuna{
                Id = idVacuna,
                NombreVacuna = "Tetano",
                TipoVacuna = "Intravenoza"
            };
        repoVacuna.EditarVacuna(vacuna);
        }

        private static void BuscarVacuna(int idVacuna){

            var vacunaEncontrada = repoVacuna.GetVacuna(idVacuna);
            Console.WriteLine("El nombre de la Vacuna es: "+vacunaEncontrada.NombreVacuna);

        }

        private static void EliminarVacuna(int idVacuna){
            repoVacuna.EliminarVacuna(idVacuna);
        }

        //-------------------HistorialClienico---------------------

        private static IRepositorioHistorialClinico repoHistorialClinico = new RepositorioHistorialClinico(new Persistencia.AppContext());

        private static void AgregarHistoriaClinico(){

            EntidadHistoriaClinico historialClinico = new EntidadHistoriaClinico{

                FechaRegistroCitaH = new DateTime(2021,05,14),
                FechaAtencionCitaH = new DateTime(2021,05,20),
                Diagnostico = "Tiene gripita",
                idVeterinario = 1,
                idCliente = 2,
                idMascota = 1
                
            };

            repoHistorialClinico.AgregarHistoriaClinico(historialClinico);
            
        }

        private static void EditarHistoriaClinico(int idHistoriaClinico){
            EntidadHistoriaClinico historialClinico = new EntidadHistoriaClinico{
                Id = idHistoriaClinico,
                Diagnostico = "Dolor de panza",
                
            };
        repoHistorialClinico.EditarHistoriaClinico(historialClinico);
        }

        private static void BuscarHistoriaClinico(int idHistoriaClinico){

            var historialClinicoEncontrada = repoHistorialClinico.GetHistoriaClinico(idHistoriaClinico);
            Console.WriteLine("El Diagnostico es: "+historialClinicoEncontrada.Diagnostico);

        }

        private static void EliminarHistoriaClinico(int idHistoriaClinico){
            repoHistorialClinico.EliminarHistoriaClinico(idHistoriaClinico);
        }

        //-------------------Citas---------------------

        private static IRepositorioCita repoCitas = new RepositorioCita(new Persistencia.AppContext());

        private static void AgregarCita(){

            EntidadCitas cita = new EntidadCitas{

                FechaRegistroCita = new DateTime(2021,03,14),
                FechaAtencionCita = new DateTime(2021,05,14),
                Triage = "nivel 1",
                idVeterinario = 1,
                idCliente = 2,
                idMascota = 1
                

            };

            repoCitas.AgregarCita(cita);

        }

        private static void EditarCita(int idCitas){
            EntidadCitas cita = new EntidadCitas{
                Id = idCitas,
                Triage = "Nivel 3"
                
            };
        repoCitas.EditarCita(cita);
        }

        private static void BuscarCita(int idCitas){

            var citaEncontrado = repoCitas.GetCita(idCitas);
            Console.WriteLine("El nivel del triaje es: "+citaEncontrado.Triage);

        }

        private static void EliminarCita(int idCitas){
            repoCitas.EliminarCita(idCitas);
        }
*/
    }

    
}
