CREATE TABLE [dbo].[HistoriaClinica]
(
	[HistoriaClinicaId]			BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_HistoriaClinicaId]	PRIMARY KEY CLUSTERED, 
    [Fecha]						DATETIME		NOT NULL, 
    [ProfesionalId]				BIGINT			NOT NULL
		CONSTRAINT [FK_HistoriaClinica_ProfesionalId]
			FOREIGN KEY REFERENCES [dbo].[Profesional](ProfesionalId)
        INDEX [idx_ProfesionalId], 
    [PacienteId]				BIGINT			NOT NULL
		CONSTRAINT [FK_HistoriaClinica_PacienteId]
			FOREIGN KEY REFERENCES [dbo].[Paciente](PacienteId)
        INDEX [idx_PacienteId], 
    [Observacion]				VARCHAR(MAX)	NOT NULL, 
    [Peso]                      DECIMAL(18, 2)  NULL
)
