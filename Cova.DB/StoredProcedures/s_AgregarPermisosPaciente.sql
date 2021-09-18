CREATE PROCEDURE [dbo].[s_AgregarPermisosPaciente]
	@IdUsuario		BIGINT

AS
BEGIN
	INSERT INTO [dbo].[UsuarioPermiso] (UsuarioID, TipoPermiso)
	VALUES
	(@IdUsuario, 0),
	(@IdUsuario, 1),
	(@IdUsuario, 2),
	(@IdUsuario, 3),
	(@IdUsuario, 4),
	(@IdUsuario, 5),
	(@IdUsuario, 6),
	(@IdUsuario, 11),
	(@IdUsuario, 12),
	(@IdUsuario, 17),
	(@IdUsuario, 18),
	(@IdUsuario, 19),
	(@IdUsuario, 20),
	(@IdUsuario, 21),
	(@IdUsuario, 28),
	(@IdUsuario, 29),
	(@IdUsuario, 32),
	(@IdUsuario, 38),
	(@IdUsuario, 39),
	(@IdUsuario, 40),
	(@IdUsuario, 42),
	(@IdUsuario, 43)
END
