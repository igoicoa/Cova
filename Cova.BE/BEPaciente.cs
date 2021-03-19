﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEPaciente
    {
        public long PacienteId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public BEDomicilio Domicilio { get; set; }
        public BECoberturaMedica CoberturaMedica { get; set; }
        public IList<BEVacunaAplicada> VacunasAplicadas { get; set; }
        public IList<BEVacuna> VacunasRecetadas { get; set; }

    }
}
