using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.WebService.Dtos;
using Cova.BL;
using Cova.BE;

namespace Cova.WebService
{
    public class RecetaService
    {
        private BLReceta bLReceta = new BLReceta();

        public IList<RecetaDto> GetRecetas()
        {
            IList<BEReceta> recetas = this.bLReceta.BuscarRecetas(new BEPaciente());
            IList<RecetaDto> recetaDtos = new List<RecetaDto>();

            foreach (BEReceta receta in recetas)
            {
                recetaDtos.Add(Mapear(receta));
            }
            return recetaDtos;
        }

        public IList<RecetaDto> GetRecetasUsuario(int pacienteId)
        {
            BEPaciente bEPaciente = new BEPaciente();
            bEPaciente.PacienteId = pacienteId;
            IList<BEReceta> recetas = this.bLReceta.BuscarRecetas(bEPaciente);
            IList<RecetaDto> recetasDtos = new List<RecetaDto>();
            foreach (BEReceta receta in recetas)
            {
                recetasDtos.Add(Mapear(receta));
            }

            return recetasDtos;
        }

        public RecetaDto CrearReceta(RecetaDto recetaDtos)
        {
            if (this.bLReceta.CrearReceta(Mapear(recetaDtos)))
            {
                return recetaDtos;
            }
            else
            {
                return null;
            }
        }

        public RecetaDto ActualizarReceta(RecetaDto receta)
        {
            if (this.bLReceta.ActualizarReceta(Mapear(receta)))
            {
                return receta;
            }
            else
            {
                return null;
            }
        }

        private static RecetaDto Mapear(BEReceta receta)
        {
            RecetaDto recetaDto = new RecetaDto();
            DomicilioDto domicilioDto = new DomicilioDto();
            CoberturaMedicaPacienteDto coberturaMedicaPacienteDto = new CoberturaMedicaPacienteDto();
            CoberturaMedicaPlanDto coberturaMedicaPlanDto = new CoberturaMedicaPlanDto();
            recetaDto.Medico.ProfesionalId = receta.Medico.ProfesionalId; //SOLO MEDICO
            recetaDto.Medico.Apellido = receta.Medico.Apellido;
            recetaDto.Medico.Nombre = receta.Medico.Nombre;
            recetaDto.Medico.DNI = receta.Medico.DNI;
            recetaDto.Medico.FechaNacimiento = receta.Medico.FechaNacimiento;
            recetaDto.Medico.Sexo = receta.Medico.Sexo;
            recetaDto.Medico.EstadoCivil = receta.Medico.EstadoCivil;
            recetaDto.Medico.Telefono = receta.Medico.Telefono;
            recetaDto.Medico.Email = receta.Medico.Email;
            recetaDto.Medico.Domicilio = domicilioDto;
            recetaDto.Medico.Domicilio.Calle = domicilioDto.Calle;
            recetaDto.Medico.Domicilio.Numero = domicilioDto.Numero;
            recetaDto.Medico.Domicilio.Piso = domicilioDto.Piso;
            recetaDto.Medico.Domicilio.Localidad = domicilioDto.Localidad;
            recetaDto.Medico.Domicilio.Provincia = domicilioDto.Provincia;
            recetaDto.Medico.Domicilio.Pais = domicilioDto.Pais;
            recetaDto.Medico.MatriculaNacional = receta.Medico.MatriculaNacional;
            recetaDto.Medico.MatriculaProvincial = receta.Medico.MatriculaProvincial;
            recetaDto.Medico.Especialidad = receta.Medico.Especialidad.ToString();
            recetaDto.FechaPrescripcion = receta.FechaPrescripcion;
            recetaDto.Observacion = receta.Observacion;
            recetaDto.Paciente.PacienteId = receta.Paciente.PacienteId;
            recetaDto.Paciente.Nombre = receta.Paciente.Nombre;
            recetaDto.Paciente.Apellido = receta.Paciente.Apellido;
            recetaDto.Paciente.DNI = receta.Paciente.DNI;
            recetaDto.Paciente.FechaNacimiento = receta.Paciente.FechaNacimiento;
            recetaDto.Paciente.Sexo = receta.Paciente.Sexo;
            recetaDto.Paciente.EstadoCivil = receta.Paciente.EstadoCivil;
            recetaDto.Paciente.Telefono = receta.Paciente.Telefono;
            recetaDto.Paciente.Email = receta.Paciente.Email;
            recetaDto.Paciente.Domicilio = domicilioDto;
            recetaDto.Paciente.Domicilio.Calle = domicilioDto.Calle;
            recetaDto.Paciente.Domicilio.Numero = domicilioDto.Numero;
            recetaDto.Paciente.Domicilio.Piso = domicilioDto.Piso;
            recetaDto.Paciente.Domicilio.Localidad = domicilioDto.Localidad;
            recetaDto.Paciente.Domicilio.Provincia = domicilioDto.Provincia;
            recetaDto.Paciente.Domicilio.Pais = domicilioDto.Pais;
            recetaDto.Paciente.CoberturaMedica = coberturaMedicaPacienteDto;
            recetaDto.Paciente.CoberturaMedica.Nombre = coberturaMedicaPacienteDto.Nombre;
            recetaDto.Paciente.CoberturaMedica.NumeroAfiliado = coberturaMedicaPacienteDto.NumeroAfiliado;
            recetaDto.Paciente.CoberturaMedica.FechaVencimiento = coberturaMedicaPacienteDto.FechaVencimiento;
            recetaDto.Paciente.CoberturaMedica.Plan = coberturaMedicaPlanDto;
            recetaDto.Paciente.CoberturaMedica.Nombre = coberturaMedicaPlanDto.Nombre;

            return recetaDto;
        }

        private static BEReceta Mapear(RecetaDto recetaDto)
        {
            BEReceta receta = new BEReceta();
            BEDomicilio domicilio = new BEDomicilio();
            receta.Medico.ProfesionalId = recetaDto.Medico.ProfesionalId;
            receta.Medico.Apellido = recetaDto.Medico.Apellido;
            receta.Medico.Nombre = recetaDto.Medico.Nombre;
            receta.Medico.DNI = recetaDto.Medico.DNI;
            receta.Medico.FechaNacimiento = recetaDto.Medico.FechaNacimiento;
            receta.Medico.Sexo = recetaDto.Medico.Sexo;
            receta.Medico.EstadoCivil = recetaDto.Medico.EstadoCivil;
            receta.Medico.Telefono = recetaDto.Medico.Telefono;
            receta.Medico.Email = recetaDto.Medico.Email;
            receta.Medico.Domicilio = domicilio;
            receta.Medico.Domicilio.Calle = recetaDto.Medico.Domicilio.Calle;
            receta.Medico.Domicilio.Numero = recetaDto.Medico.Domicilio.Numero;
            receta.Medico.Domicilio.Piso = recetaDto.Medico.Domicilio.Piso;
            receta.Medico.Domicilio.Localidad = recetaDto.Medico.Domicilio.Localidad;
            receta.Medico.Domicilio.Provincia = recetaDto.Medico.Domicilio.Provincia;
            receta.Medico.Domicilio.Pais = recetaDto.Medico.Domicilio.Pais;
            receta.Medico.MatriculaNacional = recetaDto.Medico.MatriculaNacional;
            receta.Medico.MatriculaProvincial = recetaDto.Medico.MatriculaProvincial;
            //medico.Especialidad = medicoDto.Especialidad;
            receta.FechaPrescripcion = recetaDto.FechaPrescripcion;
            receta.Observacion = recetaDto.Observacion;
            receta.Paciente.PacienteId = recetaDto.Paciente.PacienteId;
            receta.Paciente.Nombre = recetaDto.Paciente.Nombre;
            receta.Paciente.Apellido = recetaDto.Paciente.Apellido;
            receta.Paciente.DNI = recetaDto.Paciente.DNI;
            receta.Paciente.FechaNacimiento = recetaDto.Paciente.FechaNacimiento;
            receta.Paciente.Sexo = recetaDto.Paciente.Sexo;
            receta.Paciente.EstadoCivil = recetaDto.Paciente.EstadoCivil;
            receta.Paciente.Telefono = recetaDto.Paciente.Telefono;
            receta.Paciente.Email = recetaDto.Paciente.Email;
            receta.Paciente.Domicilio.Calle = recetaDto.Paciente.Domicilio.Calle;
            receta.Paciente.Domicilio.Numero = recetaDto.Paciente.Domicilio.Numero;
            receta.Paciente.Domicilio.Piso = recetaDto.Paciente.Domicilio.Piso;
            receta.Paciente.Domicilio.Localidad = recetaDto.Paciente.Domicilio.Localidad;
            receta.Paciente.Domicilio.Provincia = recetaDto.Paciente.Domicilio.Provincia;
            receta.Paciente.Domicilio.Pais = recetaDto.Paciente.Domicilio.Pais;
            receta.Paciente.CoberturaMedica.Nombre = recetaDto.Paciente.CoberturaMedica.Nombre;
            receta.Paciente.CoberturaMedica.NumeroAfiliado = recetaDto.Paciente.CoberturaMedica.NumeroAfiliado;
            receta.Paciente.CoberturaMedica.FechaVencimiento = recetaDto.Paciente.CoberturaMedica.FechaVencimiento;
            receta.Paciente.CoberturaMedica.Plan.PlanId = recetaDto.Paciente.CoberturaMedica.Plan.PlanId;
            receta.Paciente.CoberturaMedica.Nombre = recetaDto.Paciente.CoberturaMedica.Plan.Nombre;
            
            return receta;
        }
    }
}
