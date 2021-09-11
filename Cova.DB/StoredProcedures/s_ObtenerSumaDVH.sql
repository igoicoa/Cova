CREATE PROCEDURE [dbo].[s_ObtenerSumaDVH]
	@Entidad	VARCHAR(200)
AS
BEGIN
	SELECT SUM(DVH) AS DVV
	FROM [dbo].[VacunaDosis]
END
