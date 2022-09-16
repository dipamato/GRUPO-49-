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
    public class EjemplosModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioMedico _repoMedico;
        [BindProperty]
        public Medico medico{get;set;}
        [BindProperty]
        public Paciente paciente {get;set;}
        public EjemplosModel(IRepositorioPaciente repoPaciente,IRepositorioMedico repoMedico)
        {
            _repoMedico=repoMedico;
            _repoPaciente=repoPaciente;
        }
        public void OnGet()
        {
            
            
            
            paciente=_repoPaciente.ConsultarPacientexTelefono("000000");
            medico=_repoMedico.ConsultarMedico(1012);
            if(paciente!=null){
                if(paciente.Medico==null){
                    
                    if(medico==null){
                        Console.WriteLine("Error");

                    }
                    paciente.Medico=medico;
                    _repoPaciente.ActualizarPaciente(paciente); 
                }
                
                paciente.Direccion="3636363636";   
                _repoPaciente.ActualizarPaciente(paciente); 
            }
        }
    }
}
