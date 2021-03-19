CREATE TABLE [dbo].[Medico]
(
	[ProfesionalId]			BIGINT			NOT NULL	
		CONSTRAINT [PK_Medico_ProfesionalId]
			PRIMARY KEY CLUSTERED REFERENCES [dbo].[Profesional](ProfesionalId)
		CONSTRAINT [FK_Medico_ProfesionalId]
			FOREIGN KEY REFERENCES [dbo].[Profesional](ProfesionalId), 
    [MatriculaNacional]		INT				NULL, 
    [MatriculaProvincial]	INT				NULL, 
    [Especialidad]			VARCHAR(150)	NULL,


)
