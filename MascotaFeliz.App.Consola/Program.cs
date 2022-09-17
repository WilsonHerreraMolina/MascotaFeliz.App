using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddDueno();
            AddVeterinario();
            AddMascota();
            BuscarDueno(1);

        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Carlos",
                Apellidos = "Quesito",
                Direccion = "La Vuelta",
                Telefono = "88847463",
                Correo = "carlosquesito@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Lola",
                Apellidos = "Mento",
                Direccion = "La otra cuadra",
                Telefono = "42939475",
                TarjetaProfesional = "TP776453"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "sinDientes",
                Color = "VerdeMoradotirandoaamarillo",
                Especie = "Canina",
                Raza = "Doberman",
            };
            _repoMascota.AddMascota(mascota);
        }
        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine("Nombre: "+ dueno.Nombres + "Apellidos: " + dueno.Apellidos + "Direccion: "+ dueno.Direccion + "Telefono" + dueno.Telefono +"Correo: "+ dueno.Correo );
        }    
    }
}