CREATE TABLE [dbo].[CAT_TipoResponsable] (
    [Id]          INT         IDENTITY (1, 1) NOT NULL,
    [Descripcion] NCHAR (100) NOT NULL,
    [Activo]      BIT         NOT NULL,
    CONSTRAINT [PK_CAT_TipoResponsable] PRIMARY KEY CLUSTERED ([Id] ASC)
);

