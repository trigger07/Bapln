CREATE TABLE [dbo].[REL_Periodo_Institucion] (
    [Id_Periodo]     INT NOT NULL,
    [Id_Institucion] INT NOT NULL,
    CONSTRAINT [PK_REL_Periodo_Institucion] PRIMARY KEY CLUSTERED ([Id_Periodo] ASC, [Id_Institucion] ASC),
    CONSTRAINT [FK_REL_Periodo_Institucion_CAT_Periodo] FOREIGN KEY ([Id_Periodo]) REFERENCES [dbo].[CAT_Periodo] ([Id]),
    CONSTRAINT [FK_REL_Periodo_Institucion_LIS_Instituciones] FOREIGN KEY ([Id_Institucion]) REFERENCES [dbo].[LIS_Instituciones] ([Id])
);

