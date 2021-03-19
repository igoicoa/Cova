CREATE TABLE [dbo].[Domicilio]
(
	[DomicilioId]   BIGINT          NOT NULL IDENTITY(1,1)
        CONSTRAINT [PK_DomicilioId] PRIMARY KEY CLUSTERED, 
    [Calle]         VARCHAR(120)    NOT NULL, 
    [Numero]        INT             NOT NULL, 
    [Piso]          VARCHAR(20)     NULL, 
    [Localidad]     VARCHAR(120)    NOT NULL, 
    [Provincia]     VARCHAR(120)    NOT NULL, 
    [Pais]          VARCHAR(120)    NOT NULL
)
