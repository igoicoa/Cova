CREATE PROCEDURE [dbo].[s_AgregarPermisosProfesionalMedico]
	@IdUsuario		BIGINT

AS
BEGIN
	DECLARE @IDComponentePermisoRaiz INT,
			@IDComponentePermisoInicio

	INSERT INTO ComponentePermiso (TipoPermiso, FechaCreacion)
	VALUES (0, GETDATE())

	SET @IDComponentePermisoRaiz = SCOPE_IDENTITY();

	UPDATE Usuario SET FamiliaPermiso = @IDComponentePermisoRaiz WHERE UsuarioID = @IdUsuario
	
	--Permiso Inicio
	INSERT INTO ComponentePermiso (TipoPermiso, FechaCreacion)
	VALUES (1, GETDATE())
	SET @IDComponentePermisoInicio = SCOPE_IDENTITY();

	INSERT INTo FamiliaPermiso (IDPermisoPadre)
	VALUES 
	(@IDComponentePermisoInicio)

	--Permiso Inicio




END
