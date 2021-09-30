CREATE PROCEDURE [dbo].[s_RealizarBackup]
	@Nombre			VARCHAR(200),
	@Archivo		VARCHAR(500),
	@UsuarioId		BIGINT
AS
BEGIN
	DECLARe @strSQL VARCHAR(MAX);
	BEGIN TRY
		SET @strSQL = 'USE COVA;
					BACKUP DATABASE Cova
					TO DISK = ''' + @Archivo +
					''' WITH FORMAT ,MEDIANAME = ''Z_SQL_ServerBackups'' ,NAME = ''' + @Nombre + ''';'
		EXEC(@strSQL);

		INSERT INTO [dbo].[Backups] (UsuarioId, FechaBackup, Nombre, Archivo)
		VALUES
		(@UsuarioId, GETDATE(), @Nombre, @Archivo)

	END TRY
	BEGIN CATCH
		RETURN -1
	END CATCH
END
