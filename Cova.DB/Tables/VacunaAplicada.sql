CREATE TABLE [dbo].[VacunaAplicada]
(
	[VacunaAplicadaId]			BIGINT	NOT NULL IDENTITY(1,1)
		CONSTRAINT	[PK_VacunaAplicadaId]	PRIMARY KEY CLUSTERED, 
    [VacunaId]					INT		NOT NULL
		CONSTRAINT [FK_VacunaAplicada_VacunaId]
			FOREIGN KEY REFERENCES [dbo].[Vacuna](VacunaId)
        INDEX [idx_VacunaId], 
    [DosisAplicadas]			INT		NULL, 
    [CentroMedicoAplicacionId]	INT		NOT NULL
		CONSTRAINT [FK_VacunaAplicada_CentroMedicoId]
			FOREIGN KEY REFERENCES [dbo].[CentroMedico](CentroMedicoId)
        INDEX [idx_CentroMedicoId]

)
