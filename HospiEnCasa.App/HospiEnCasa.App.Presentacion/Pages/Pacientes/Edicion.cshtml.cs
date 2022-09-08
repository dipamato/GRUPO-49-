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
    public class EdicionModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        [BindProperty]
        public Paciente paciente {get;set;}

        public EdicionModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente=repoPaciente;
        }
        public void OnGet(int pacienteId)
        {
            paciente=_repoPaciente.ConsultarPaciente(pacienteId);
        }

        public async Task<IActionResult> OnPost()
        {
            Console.WriteLine(paciente.Id);
            paciente=_repoPaciente.ActualizarPaciente(paciente);
            if(paciente==null)
            {
                return Page();
            }
            return RedirectToPage("/Pacientes/ConsultaP");
        }
    }
}
