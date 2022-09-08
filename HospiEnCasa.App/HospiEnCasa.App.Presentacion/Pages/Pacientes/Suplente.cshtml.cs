using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class  SuplenteModel: PageModel
    {
         private readonly IRepositorioPaciente _repoPaciente;
        [BindProperty]
        public Paciente paciente {get;set;}

        public SuplenteModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente=repoPaciente;
        }
        public string telefono{get;set;}

        public void OnGet()
        {
            
            paciente=new Paciente();
        }

        public async Task<IActionResult> OnPost()
        {
            paciente=_repoPaciente.ConsultarPacientexTelefono(paciente.NumeroTelefono);
            if(paciente==null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostEdit()
        {
            paciente=_repoPaciente.ActualizarPaciente(paciente);
            if(paciente!=null)
            {
                return RedirectToPage("/Pacientes/ConsultaP");
            }
            return RedirectToPage("/Error");
        }
            
          
    }
}
