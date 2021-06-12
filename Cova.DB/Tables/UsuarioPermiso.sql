CREATE TABLE [dbo].[UsuarioPermiso]
(
	[UsuarioID]		BIGINT		NOT NULL
	CONSTRAINT [FK_Permiso_UsuarioId]
			FOREIGN KEY REFERENCES [dbo].[Usuario](UsuarioId)
        INDEX [idx_UsuarioId],
    [TipoPermiso]	INT		NOT NULL
)
