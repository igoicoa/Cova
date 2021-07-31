CREATE TABLE [dbo].[Receta]
(
	[RecetaId]          BIGINT			NOT NULL    IDENTITY(1,1)	
		CONSTRAINT [PK_RecetaIdId] PRIMARY KEY CLUSTERED, 
    [FechaPrescripcion] DATETIME        NOT NULL, 
    [PacienteId]        BIGINT          NOT NULL
        CONSTRAINT [FK_Receta_PacientelId]
			FOREIGN KEY REFERENCES [dbo].[Paciente](PacienteId),
    [ProfesionalId]          BIGINT          NOT NULL
        CONSTRAINT [FK_Receta_ProfesionalId]
			FOREIGN KEY REFERENCES [dbo].[Profesional](ProfesionalId),
    [VacunaId]          INT             NULL
        CONSTRAINT [FK_Receta_VacunalId]
			FOREIGN KEY REFERENCES [dbo].[Vacuna](VacunaId),
    [Observacion]       VARCHAR(MAX)    NULL
)
