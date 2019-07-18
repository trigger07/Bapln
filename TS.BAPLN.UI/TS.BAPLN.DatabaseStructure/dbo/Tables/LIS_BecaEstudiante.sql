CREATE TABLE [dbo].[LIS_BecaEstudiante] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [FechaInicio]    DATETIME        NOT NULL,
    [FechaFinal]     DATETIME        NOT NULL,
    [Id_Estudiante]  INT             NOT NULL,
    [Id_Beca]        INT             NOT NULL,
    [Activa]         BIT             NOT NULL,
    [MontoTotal]     DECIMAL (18, 2) NULL,
    [MontoCuota]     DECIMAL (18, 2) NULL,
    [CantidadCuotas] SMALLINT        NULL,
    CONSTRAINT [PK_LIS_BecaEstudiante] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LIS_BecaEstudiante_CAT_Beca] FOREIGN KEY ([Id_Beca]) REFERENCES [dbo].[CAT_Beca] ([Id]),
    CONSTRAINT [FK_LIS_BecaEstudiante_LIS_Estudiante] FOREIGN KEY ([Id_Estudiante]) REFERENCES [dbo].[LIS_Estudiante] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_LIS_BecaEstudiante_CAT_Beca]
    ON [dbo].[LIS_BecaEstudiante]([Id_Beca] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_LIS_BecaEstudiante_LIS_Estudiante]
    ON [dbo].[LIS_BecaEstudiante]([Id_Estudiante] ASC);

