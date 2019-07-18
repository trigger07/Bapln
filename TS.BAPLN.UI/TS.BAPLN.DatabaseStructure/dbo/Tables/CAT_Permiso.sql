CREATE TABLE [dbo].[CAT_Permiso] (
    [Id_Permiso]  INT            IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_CAT_Permiso] PRIMARY KEY CLUSTERED ([Id_Permiso] ASC)
);

