CREATE TABLE [dbo].[TurnoDisponible]
(
	[TurnoDisponibleId]	            BIGINT		NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_TurnoDisponibleId]	PRIMARY KEY CLUSTERED, 
    [ProfesionalId]         BIGINT              NOT NULL
        CONSTRAINT [FK_TurnoDisponible_ProfesionalId]
			FOREIGN KEY REFERENCES [dbo].[Profesional](ProfesionalId)
        INDEX [idx_ProfesionalId],
	[DiaSemana]				VARCHAR(20)		    NOT NULL, 
    [HoraDesde]             DATETIME            NOT NULL, 
    [HoraHasta]             DATETIME            NOT NULL			
)
