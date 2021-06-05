CREATE TABLE [dbo].[FamiliaPermiso]
(
	[IDPermiso]					INT		NOT NULL
		CONSTRAINT [FK_FamiliaPermiso_ComponentePermiso] FOREIGN KEY([IDPermiso])
		REFERENCES [dbo].[ComponentePermiso] ([IDPermiso]),
	[IDPermisoPadre]			INT		NULL
		CONSTRAINT [FK_FamiliaPermiso_PermisoPadre] FOREIGN KEY([IDPermiso])
		REFERENCES [dbo].[ComponentePermiso] ([IDPermiso])
)
