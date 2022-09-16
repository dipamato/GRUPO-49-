using HospiEnCasa.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext = new AppContext();

        public Medico CrearMedico(Medico medico)
        {
            var medicoAdicionado=_appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }
    
        public Medico ConsultarMedico(int idMedico)
        {
           return _appContext.Medicos.FirstOrDefault(m=>m.Id==idMedico);
            
        }

        public Medico ConsultarMedicoxCodigo(string codigo)
        {
           return _appContext.Medicos.FirstOrDefault(m=>m.Codigo==codigo);
            
        }

        public IEnumerable<Medico> ConsultarMedicos()
        {
            return _appContext.Medicos;
        }

        public Medico ActualizarMedico(Medico medico)
        {
            var medicoEncontrado= _appContext.Medicos.FirstOrDefault(m=>m.Id==medico.Id);
            if(medicoEncontrado!=null){
                medicoEncontrado.Nombre=medico.Nombre;
                medicoEncontrado.Apellidos=medico.Apellidos;
                medicoEncontrado.NumeroTelefono=medico.NumeroTelefono;
                medicoEncontrado.Genero=medico.Genero;
                medicoEncontrado.Codigo=medico.Codigo;
                medicoEncontrado.Especialidad=medico.Especialidad;
                medicoEncontrado.RegistroRethus=medico.RegistroRethus;

                _appContext.SaveChanges();

                }
                return medicoEncontrado;

        }
        public void EliminarMedico(int idMedico)
        {
            var medicoEncontrado=_appContext.Medicos.FirstOrDefault(m=>m.Id==idMedico);
            if(medicoEncontrado!=null)
            {
                _appContext.Medicos.Remove(medicoEncontrado);
                _appContext.SaveChanges();
            }
        }

        public List<SelectListItem> ConsultarMedicosxNombre()
        {
           return _appContext.Medicos.Select(m=> new SelectListItem
            {
                Value=(m.Nombre+" "+m.Apellidos+"-"+m.Especialidad).ToString(),
                Text=(m.Nombre+" "+m.Apellidos+"-"+m.Especialidad+" "+m.Codigo)
            }).ToList();
        }
    }
}