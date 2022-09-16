using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class  SuplenteModel: PageModel
    {
         private readonly IRepositorioPaciente _repoPaciente;
         private readonly IRepositorioMedico _repoMedico;
        [BindProperty]
        public Paciente paciente {get;set;}
      
        public List<SelectListItem> nombresM{get;set;}
        [BindProperty]
        public Medico medico{get;set;}
        public string Elemento{get;set;}

        public SuplenteModel(IRepositorioPaciente repoPaciente, IRepositorioMedico repoMedico)
        {
            _repoPaciente=repoPaciente;
            _repoMedico=repoMedico;
            

        }
        public string telefono{get;set;}

        public void OnGet()
        {
            Elemento=" ";
            paciente=new Paciente();
            medico=new Medico();
            nombresM=new List<SelectListItem>();
            nombresM=_repoMedico.ConsultarMedicosxNombre();
        }

        public async Task<IActionResult> OnPost()
        {
            nombresM=_repoMedico.ConsultarMedicosxNombre();
            medico=_repoMedico.ConsultarMedico(1018);
            paciente=_repoPaciente.ConsultarPacientexTelefono(paciente.NumeroTelefono);
            if(paciente==null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostEdit()
        {
            string Nombre=Request.Form["valor"];
            var x=Nombre.Split(' ');
            var num=x.Length;
            Console.WriteLine("este es el nombre: "+x[num-1]);
            medico = _repoMedico.ConsultarMedicoxCodigo(x[num-1]);
            Console.WriteLine("este es el nombre: "+medico.Nombre);
            paciente=_repoPaciente.ActualizarPaciente(paciente);
            if(paciente!=null)
            {
                paciente.Medico=medico;
                _repoPaciente.ActualizarPaciente(paciente);
                return RedirectToPage("/Pacientes/ConsultaP");
            }
            return RedirectToPage("/Error");
            
        }
            
          
    }
}
