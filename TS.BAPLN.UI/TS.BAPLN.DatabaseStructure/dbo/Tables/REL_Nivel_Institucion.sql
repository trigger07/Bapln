CREATE TABLE [dbo].[REL_Nivel_Institucion] (
    [Id_Nivel]       INT NOT NULL,
    [Id_Institucion] INT NOT NULL,
    CONSTRAINT [PK_REL_Nivel_Institucion] PRIMARY KEY CLUSTERED ([Id_Nivel] ASC, [Id_Institucion] ASC),
    CONSTRAINT [FK_REL_Nivel_Institucion_CAT_Nivel] FOREIGN KEY ([Id_Nivel]) REFERENCES [dbo].[CAT_Nivel] ([Id]),
    CONSTRAINT [FK_REL_Nivel_Institucion_LIS_Instituciones] FOREIGN KEY ([Id_Institucion]) REFERENCES [dbo].[LIS_Instituciones] ([Id])
);

