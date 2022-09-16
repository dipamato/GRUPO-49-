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
    public class RegistroMedicoModel : PageModel

    {
        private readonly IRepositorioMedico _repoMedico;
        private readonly IRepositorioPaciente _repoPaciente;
        [BindProperty]
        public Medico medico{get;set;}
        public Paciente paciente{get;set;}

        public RegistroMedicoModel(IRepositorioMedico repoMedico, IRepositorioPaciente repoPaciente)
        {
            _repoMedico=repoMedico;
            _repoPaciente=repoPaciente;
        }
        public void OnGet()
        {
            medico=new Medico();
            paciente=new Paciente();
            
        }

        public async Task<IActionResult> OnPost()
        {
            medico=_repoMedico.CrearMedico(medico);
            if(medico!=null){
                return RedirectToPage("/Index");
            }
            return RedirectToPage("/Error");
        }

       
    }
}
