using Cova.BE;

namespace Cova.UI.Interfaces
{
    public interface IFormCargarRecetasCertificados
    {
        void CargarRecetaPaciente(BEReceta receta, BEPaciente paciente);
        void CargarCertificadoPaciente(BECertificado certificado, BEPaciente paciente);
    }
}
