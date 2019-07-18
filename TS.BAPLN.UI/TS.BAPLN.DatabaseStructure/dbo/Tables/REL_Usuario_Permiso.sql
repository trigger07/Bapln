CREATE TABLE [dbo].[REL_Usuario_Permiso] (
    [Id_Usuario] NVARCHAR (50) NOT NULL,
    [Id_Permiso] INT           NOT NULL,
    CONSTRAINT [PK_REL_Usuario_Permiso] PRIMARY KEY CLUSTERED ([Id_Usuario] ASC, [Id_Permiso] ASC),
    CONSTRAINT [FK_REL_Usuario_Permiso_CAT_Permiso] FOREIGN KEY ([Id_Permiso]) REFERENCES [dbo].[CAT_Permiso] ([Id_Permiso]),
    CONSTRAINT [FK_REL_Usuario_Permiso_LIS_Usuario] FOREIGN KEY ([Id_Usuario]) REFERENCES [dbo].[LIS_Usuario] ([Id_Usuario])
);

