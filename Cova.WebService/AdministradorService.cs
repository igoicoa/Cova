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
    public class AdministradorService
    {
        private BLAdministrador bLAdministrador = new BLAdministrador();

        public IList<AdministradorDto> GetAdministrador()
        {
            IList<BEAdministrador> administradores = this.bLAdministrador.BuscarAdministrador("", "");
            IList<AdministradorDto> administradorDtos = new List<AdministradorDto>();

            foreach (BEAdministrador administrador in administradores)
            {
                administradorDtos.Add(Mapear(administrador));
            }
            return administradorDtos;
        }

        public AdministradorDto GetAdministrador(int usuarioId)
        {
            IList<BEAdministrador> administrador = this.bLAdministrador.BuscarAdministrador("", "");
            AdministradorDto administradorDto = Mapear(administrador.Where(x => x.UsuarioID == usuarioId).FirstOrDefault());

            return administradorDto;
        }

        public AdministradorDto CrearAdministrador(AdministradorDto administrador)
        {
            if (this.bLAdministrador.CrearAdministrador(Mapear(administrador)))
            {
                return administrador;
            }
            else
            {
                return null;
            }
        }

        public AdministradorDto ActualizarAdministrador(AdministradorDto administrador)
        {
            if (this.bLAdministrador.ActualizarAdministrador(Mapear(administrador), Mapear(administrador)))
            {
                return administrador;
            }
            else
            {
                return null;
            }
        }

        //public AdministradorDto BorrarAdministrador(int usuarioId)
        //{
        //    return usuarioId;
        //}

        private static AdministradorDto Mapear(BEAdministrador administrador)
        {
            AdministradorDto administradorDto = new AdministradorDto();
            administradorDto.UsuarioID = administrador.UsuarioID;
            administradorDto.Apellido = administrador.Apellido;
            administradorDto.Nombre = administrador.Nombre;
            administradorDto.Sexo = administrador.Sexo;

            return administradorDto;
        }

        private static BEAdministrador Mapear(AdministradorDto administradorDto)
        {
            BEAdministrador administrador = new BEAdministrador();
            administrador.UsuarioID = administradorDto.UsuarioID;
            administrador.Apellido = administradorDto.Apellido;
            administrador.Nombre = administradorDto.Nombre;
            administrador.Sexo = administradorDto.Sexo;

            return administrador;
        }
    }
}
