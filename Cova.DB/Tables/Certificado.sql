CREATE TABLE [dbo].[Certificado]
(
	[CertificadoId]          BIGINT			NOT NULL    IDENTITY(1,1)	
		CONSTRAINT [PK_CertificadoId] PRIMARY KEY CLUSTERED, 
    [FechaPrescripcion] DATETIME        NOT NULL, 
    [PacienteId]        BIGINT          NOT NULL
        CONSTRAINT [FK_Certificado_PacientelId]
			FOREIGN KEY REFERENCES [dbo].[Paciente](PacienteId),
    [ProfesionalId]          BIGINT          NOT NULL
        CONSTRAINT [FK_Certificado_ProfesionalId]
			FOREIGN KEY REFERENCES [dbo].[Profesional](ProfesionalId),
    [Observacion]       VARCHAR(MAX)    NULL
)
