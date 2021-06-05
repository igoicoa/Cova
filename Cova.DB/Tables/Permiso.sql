CREATE TABLE [dbo].[Permiso]
(
	[IDPermiso]			INT		NOT NULL,
		CONSTRAINT [FK_Permiso_ComponentePermiso] FOREIGN KEY([IDPermiso])
		REFERENCES [dbo].[ComponentePermiso] ([IDPermiso]),
	[IDPermisoPadre]	INT		NULL
		CONSTRAINT [FK_Permiso_FamiliaPermiso] FOREIGN KEY([IDPermiso])
		REFERENCES [dbo].[ComponentePermiso] ([IDPermiso])
)
