CREATE TABLE [dbo].[AntecedentesPersonales_Paciente]
(
	[AntecedentesPersonales_Paciente_Id]	BIGINT			NOT NULL	IDENTITY(1,1)
		CONSTRAINT	[PK_AntecedentesPersonales_Paciente_Id]	PRIMARY KEY CLUSTERED, 
	[AntecedentesPersonalesId]				INT				NOT NULL
		CONSTRAINT [FK_AntecedentesPersonalesPaciente_AntecedentesPersonalesId]
			FOREIGN KEY REFERENCES [dbo].[AntecedentesPersonales](AntecedenteId)
        INDEX [idx_AntecedenteId],
    [PacienteId]							BIGINT			NOT NULL
		CONSTRAINT [FK_AntecedentesPersonalesPaciente_PacienteId]
			FOREIGN KEY REFERENCES [dbo].[Paciente](PacienteId)
        INDEX [idx_PacienteId]
)
