CREATE TABLE [dbo].[CAT_CursoLectivo] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (200) NULL,
    CONSTRAINT [PK_CAT_CursoLectivo] PRIMARY KEY CLUSTERED ([Id] ASC)
);

