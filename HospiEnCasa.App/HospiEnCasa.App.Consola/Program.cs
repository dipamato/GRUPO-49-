using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente =new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarPaciente();
        }
        private static void AdicionarPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Olga",
                Apellidos="Arismendi",
                NumeroTelefono="456789",
                Genero=Genero.Femenino,
                Direccion=" Calle 98 Carrera 6",
                Latitud=2.56F,
                Longitud=-6.3F,
                Ciudad="Medellin",
                FechaNacimiento=new DateTime(1998,06,27)
            };
            _repoPaciente.CrearPaciente(paciente);
        }
    }
}
