using Cova.BE;

namespace Cova.UI.Interfaces
{
    public interface IFormCargarCertificados
    {
        void CargarCertificadoPaciente(BECertificado certificado, BEPaciente paciente);
    }
}
