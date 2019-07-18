CREATE TABLE [dbo].[CAT_Estado] (
    [Id]          INT         IDENTITY (1, 1) NOT NULL,
    [Descripcion] NCHAR (100) NULL,
    [Activo]      BIT         NOT NULL,
    CONSTRAINT [PK_CAT_Estado] PRIMARY KEY CLUSTERED ([Id] ASC)
);

