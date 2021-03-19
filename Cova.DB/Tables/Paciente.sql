CREATE TABLE [dbo].[Paciente]
(
	[PacienteId]	    BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	PK_PacienteId	PRIMARY KEY CLUSTERED, 
    [Nombre]		    VARCHAR(120)	NOT NULL, 
    [Apellido]		    VARCHAR(120)	NOT NULL, 
    [DNI]               INT             NOT NULL, 
    [FechaNacimiento]   DATE            NOT NULL,
    [Email]             VARCHAR(120)    NOT NULL
)
