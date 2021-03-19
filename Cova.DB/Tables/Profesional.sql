CREATE TABLE [dbo].[Profesional]
(
	[ProfesionalId]	    BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	PK_ProfesionalId	PRIMARY KEY CLUSTERED, 
    [Apellido]          VARCHAR(120)    NOT NULL, 
    [Nombre]            VARCHAR(120)    NOT NULL, 
    [DNI]               INT             NOT NULL, 
    [FechaNacimiento]   DATE            NOT NULL, 
    [Email]             VARCHAR(120)    NOT NULL
)
