﻿CREATE PROCEDURE [dbo].[s_InactivarUsuario]
	@UsuarioId	BIGINT
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY

		UPDATE [dbo].[Usuario] SET
				Activo = 0
		WHERE UsuarioID = @UsuarioId

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
	END CATCH
END