CREATE PROCEDURE [dbo].[s_GenerarTurno]
	@PacienteId			BIGINT,
	@ProfesionalId		BIGINT,
	@CentroMedicoId		INT,
	@Fecha				DATETIME,
	@Comentarios		VARCHAR(250)
AS
BEGIN
	INSERT INTO [dbo].[Turno] (PacienteId, ProfesionalId, CentroMedicoId, Fecha, Comentarios)
	VALUES
	(@PacienteId, @ProfesionalId, @CentroMedicoId, @Fecha, @Comentarios)
END
