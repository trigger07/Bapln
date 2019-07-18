CREATE TABLE [dbo].[REL_Materia_Institucion] (
    [Id_Materia]     INT NOT NULL,
    [Id_Institucion] INT NOT NULL,
    CONSTRAINT [PK_REL_Materia_Institucion] PRIMARY KEY CLUSTERED ([Id_Materia] ASC, [Id_Institucion] ASC),
    CONSTRAINT [FK_REL_Materia_Institucion_CAT_Materia] FOREIGN KEY ([Id_Materia]) REFERENCES [dbo].[CAT_Materia] ([Id]),
    CONSTRAINT [FK_REL_Materia_Institucion_LIS_Instituciones] FOREIGN KEY ([Id_Institucion]) REFERENCES [dbo].[LIS_Instituciones] ([Id])
);

