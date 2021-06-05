CREATE PROCEDURE s_ObtenerFamiliaPermisoUsuario
	@IDUsuario int
AS
BEGIN
	SET NOCOUNT ON;

    ;WITH arbolCTE(IDPermiso, TipoPermiso, FechaCreacion, IDPermisoPadre, EsPermiso, Nivel) AS
    (
        SELECT cp.IDPermiso, cp.TipoPermiso, cp.FechaCreacion, ISNULL(fp.IDPermisoPadre, 0), 0, 0
        FROM [dbo].[ComponentePermiso] cp
	    INNER JOIN [dbo].[Usuario] u ON u.FamiliaPermiso = cp.IDPermiso
	    INNER JOIN [dbo].[FamiliaPermiso] fp ON fp.IDPermiso = cp.IDPermiso
        WHERE u.UsuarioID = @IDUsuario
        UNION ALL
        SELECT cp.IDPermiso, cp.TipoPermiso, cp.FechaCreacion, ISNULL(fp.IDPermisoPadre, 0), 0, Nivel + 1
        FROM [dbo].[ComponentePermiso] cp
	    INNER JOIN [dbo].[FamiliaPermiso] fp ON fp.IDPermiso = cp.IDPermiso 
        INNER JOIN arbolCTE AS E
        ON (fp.IDPermisoPadre = E.IDPermiso )
    )

    SELECT IDPermiso, TipoPermiso, FechaCreacion, IDPermisoPadre, EsPermiso, Nivel
    FROM arbolCTE 
    UNION ALL
    SELECT cp.IDPermiso, cp.TipoPermiso, cp.FechaCreacion, pe.IDPermisoPadre, 1, a.Nivel + 1
    FROM arbolCTE a
    INNER JOIN [dbo].[Permiso] pe ON pe.IDPermisoPadre = a.IDPermiso
    INNER JOIN [dbo].[ComponentePermiso] cp ON cp.IDPermiso = pe.IDPermiso
    ORDER BY Nivel
END
GO
