CREATE TABLE [dbo].[Turno]
(
	[TurnoId]	            BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_TurnoId]	PRIMARY KEY CLUSTERED, 
    [Fecha] DATETIME NOT NULL, 
    [ProfesionalId]         BIGINT          NOT NULL
        CONSTRAINT [FK_Turno_ProfesionalId]
			FOREIGN KEY REFERENCES [dbo].[Profesional](ProfesionalId)
        INDEX [idx_ProfesionalId],  
    [PacienteId]            BIGINT          NOT NULL
        CONSTRAINT [FK_Turno_PacienteId]
			FOREIGN KEY REFERENCES [dbo].[Paciente](PacienteId)
        INDEX [idx_PacienteId],  
    [CentroMedicoId]        INT             NOT NULL
        CONSTRAINT [FK_Turno_CentroMedicoId]
			FOREIGN KEY REFERENCES [dbo].[CentroMedico](CentroMedicoId)
        INDEX [idx_CentroMedicoId],  
    [Asistio]               BIT             NOT NULL    DEFAULT 0,
    [Comentarios]           VARCHAR(250)    NULL
)
