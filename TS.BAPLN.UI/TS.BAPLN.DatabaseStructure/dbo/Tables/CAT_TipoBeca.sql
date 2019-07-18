CREATE TABLE [dbo].[CAT_TipoBeca] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_CAT_TipoBeca] PRIMARY KEY CLUSTERED ([Id] ASC)
);

