CREATE TABLE [dbo].[VacunaAplicada]
(
	[VacunaAplicadaId]			BIGINT			NOT NULL IDENTITY(1,1)
		CONSTRAINT	[PK_VacunaAplicadaId]	PRIMARY KEY CLUSTERED, 
    [VacunaId]					INT				NOT NULL
		CONSTRAINT [FK_VacunaAplicada_VacunaId]
			FOREIGN KEY REFERENCES [dbo].[Vacuna](VacunaId)
        INDEX [idx_VacunaId], 
    [DosisAplicada]				INT				NOT NULL,
	[FechaAplicacion]			DATETIME		NOT NULL,
    [CentroMedicoAplicacionId]	INT				NOT NULL
		CONSTRAINT [FK_VacunaAplicada_CentroMedicoId]
			FOREIGN KEY REFERENCES [dbo].[CentroMedico](CentroMedicoId)
        INDEX [idx_CentroMedicoId], 
    [ObservacionProfesional]	VARCHAR(350)	NULL

)
