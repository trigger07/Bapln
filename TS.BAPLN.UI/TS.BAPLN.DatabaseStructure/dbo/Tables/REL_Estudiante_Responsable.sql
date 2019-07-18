CREATE TABLE [dbo].[REL_Estudiante_Responsable] (
    [Id_Estudiante]  INT NOT NULL,
    [Id_Responsable] INT NOT NULL,
    CONSTRAINT [PK_REL_Estudiante_Responsable] PRIMARY KEY CLUSTERED ([Id_Estudiante] ASC, [Id_Responsable] ASC),
    CONSTRAINT [FK_REL_Estudiante_Responsable_LIS_Estudiante] FOREIGN KEY ([Id_Estudiante]) REFERENCES [dbo].[LIS_Estudiante] ([Id]),
    CONSTRAINT [FK_REL_Estudiante_Responsable_LIS_Responsable] FOREIGN KEY ([Id_Responsable]) REFERENCES [dbo].[LIS_Responsable] ([Id])
);

