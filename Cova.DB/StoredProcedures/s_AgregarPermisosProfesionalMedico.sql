CREATE PROCEDURE [dbo].[s_AgregarPermisosProfesionalMedico]
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
	(@IdUsuario, 15),
	(@IdUsuario, 16),
	(@IdUsuario, 17),
	(@IdUsuario, 20),
	(@IdUsuario, 21),
	(@IdUsuario, 26),
	(@IdUsuario, 27),
	(@IdUsuario, 28),
	(@IdUsuario, 29),
	(@IdUsuario, 30),
	(@IdUsuario, 31),
	(@IdUsuario, 32),
	(@IdUsuario, 37),
	(@IdUsuario, 38),
	(@IdUsuario, 41),
	(@IdUsuario, 42)
END

