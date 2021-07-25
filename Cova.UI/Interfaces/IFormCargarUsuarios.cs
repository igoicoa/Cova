using Cova.BE;

namespace Cova.UI
{
    public interface IFormCargarUsuarios
    {
        void CargarUsuarioMedico(BEMedico usuarioAModificar);

        void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar);

        void CargarUsuarioPaciente(BEPaciente usuarioAModificar);

        void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar);
    }
}
