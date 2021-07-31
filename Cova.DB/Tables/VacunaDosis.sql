CREATE TABLE [dbo].[VacunaDosis]
(
	[Lote]			        VARCHAR(100)	NOT NULL
		CONSTRAINT	[PK_Lote]	PRIMARY KEY CLUSTERED, 
    [VacunaId]		        INT             NOT NULL
        CONSTRAINT [FK_VacunaDosis_VacunaId]
			FOREIGN KEY REFERENCES [dbo].[Vacuna](VacunaId)
        INDEX [idx_VacunaId], 
    [FechaElaboracion]      DATETIME        NOT NULL, 
    [FechaVencimiento]      DATETIME        NOT NULL, 
    [CentroMedicoId]        INT             NOT NULL
        CONSTRAINT [FK_VacunaDosis_CentroMedicoId]
			FOREIGN KEY REFERENCES [dbo].[CentroMedico](CentroMedicoId)
        INDEX [idx_CentroMedicoId], 
    [PacienteId]            BIGINT          NULL
        CONSTRAINT [FK_VacunaDosis_PacienteId]
			FOREIGN KEY REFERENCES [dbo].[Paciente](PacienteId)
        INDEX [idx_PacienteId],  
    [FechaAplicacion]       DATETIME        NULL,
    [Dosis]                 INT             NULL, 
    [ObservacionPaciente]   VARCHAR(MAX)    NULL, 
    [IndicacionMedico]      VARCHAR(MAX)    NULL, 
)
