CREATE PROCEDURE [dbo].[s_AgregarPermisosAdministrador]
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
	(@IdUsuario, 7),
	(@IdUsuario, 8),
	(@IdUsuario, 9),
	(@IdUsuario, 10),
	(@IdUsuario, 11),
	(@IdUsuario, 13),
	(@IdUsuario, 14),
	(@IdUsuario, 15),
	(@IdUsuario, 22),
	(@IdUsuario, 23),
	(@IdUsuario, 24),
	(@IdUsuario, 25),
	(@IdUsuario, 33),
	(@IdUsuario, 34),
	(@IdUsuario, 35),
	(@IdUsuario, 36),
	(@IdUsuario, 37),
	(@IdUsuario, 38),
	(@IdUsuario, 39),
	(@IdUsuario, 40),
	(@IdUsuario, 41),
	(@IdUsuario, 42)
END