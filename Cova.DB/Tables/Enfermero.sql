CREATE TABLE [dbo].[Enfermero]
(
	[ProfesionalId]			BIGINT	NOT NULL	
		CONSTRAINT [PK_Enfermero_ProfesionalId]
			PRIMARY KEY CLUSTERED REFERENCES [dbo].[Profesional](ProfesionalId)
		CONSTRAINT [FK_Enfermero_ProfesionalId]
			FOREIGN KEY REFERENCES [dbo].[Profesional](ProfesionalId), 
    [MatriculaEnfermero]		INT		NOT NULL 
)
