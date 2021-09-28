CREATE PROCEDURE [dbo].[s_ObtenerBackups]

AS
BEGIN
	SELECT b.BackupId
	      ,b.Archivo
		  ,b.Nombre
		  ,b.FechaBackup
		  ,u.UsuarioID
		  ,u.Usuario
	FROM [dbo].[Backups] b
	INNER JOIN [dbo].[Usuario] u ON u.UsuarioID = b.UsuarioId
END
