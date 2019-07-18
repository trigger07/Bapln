CREATE TABLE [dbo].[CAT_Materia] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (250) NULL,
    CONSTRAINT [PK_CAT_Materia] PRIMARY KEY CLUSTERED ([Id] ASC)
);

