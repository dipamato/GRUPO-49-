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
    public class SignosVitalesModel : PageModel
    {
        [BindProperty]
        public SignoVital signoVital{get;set;}
        public Paciente paciente{get;set;}
        private readonly IRepositorioPaciente _repoPaciente;
        public SignosVitalesModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente=repoPaciente;
        }
        public void OnGet()
        {
            signoVital=new SignoVital();
            paciente= new Paciente();
        }

        public async Task<IActionResult> OnPost(int pacienteId)
        {
            paciente =_repoPaciente.ConsultarPaciente(pacienteId);
            if(paciente!=null)
            {
                if(paciente.SignosVitales==null)
                {
                    paciente.SignosVitales=new List<SignoVital>();
                    paciente.SignosVitales.Add(signoVital);
                }
                else
                {
                    paciente.SignosVitales.Add(signoVital);
                }
                _repoPaciente.ActualizarPaciente(paciente);
                return Page();
            }
            return RedirectToPage("/Error");
        }
    }
}
