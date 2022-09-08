using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class ConsultaPModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public IEnumerable<Paciente> listaPacientes{get;set;}
        public ConsultaPModel(IRepositorioPaciente repopaciente)
        {
            _repoPaciente=repopaciente;
        }
        public void OnGet(int pacienteId)
        {
            listaPacientes =new List<Paciente>();
            listaPacientes=_repoPaciente.ConsultarPacientes();
            _repoPaciente.EliminarPaciente(pacienteId);
        }
    }
}
