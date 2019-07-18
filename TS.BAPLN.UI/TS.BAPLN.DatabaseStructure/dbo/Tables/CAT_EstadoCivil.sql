CREATE TABLE [dbo].[CAT_EstadoCivil] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (50) NULL,
    [Activo]      BIT           NULL,
    CONSTRAINT [PK_CAT_EstadoCivil] PRIMARY KEY CLUSTERED ([Id] ASC)
);

