CREATE TABLE [dbo].[HIS_HistorialAcademico] (
    [Id]              INT      IDENTITY (1, 1) NOT NULL,
    [Id_Estudiante]   INT      NOT NULL,
    [Id_Materia]      INT      NOT NULL,
    [Id_Periodo]      INT      NOT NULL,
    [Id_Nivel]        INT      NOT NULL,
    [Nota]            SMALLINT NOT NULL,
    [Id_CursoLectivo] INT      NOT NULL,
    [Id_Institucion]  INT      NOT NULL,
    CONSTRAINT [PK_HIS_HistorialAcademico_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_HIS_HistorialAcademico_CUR_CursoLectivo] FOREIGN KEY ([Id_CursoLectivo]) REFERENCES [dbo].[CAT_CursoLectivo] ([Id]),
    CONSTRAINT [FK_HIS_HistorialAcademico_EST_Estudiante] FOREIGN KEY ([Id_Estudiante]) REFERENCES [dbo].[LIS_Estudiante] ([Id]),
    CONSTRAINT [FK_HIS_HistorialAcademico_LIS_Instituciones] FOREIGN KEY ([Id_Institucion]) REFERENCES [dbo].[LIS_Instituciones] ([Id]),
    CONSTRAINT [FK_HIS_HistorialAcademico_MAT_Materia] FOREIGN KEY ([Id_Materia]) REFERENCES [dbo].[CAT_Materia] ([Id]),
    CONSTRAINT [FK_HIS_HistorialAcademico_NIV_Nivel] FOREIGN KEY ([Id_Nivel]) REFERENCES [dbo].[CAT_Nivel] ([Id]),
    CONSTRAINT [FK_HIS_HistorialAcademico_PER_Periodo] FOREIGN KEY ([Id_Periodo]) REFERENCES [dbo].[CAT_Periodo] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_HIS_HistorialAcademico_PER_Periodo]
    ON [dbo].[HIS_HistorialAcademico]([Id_Periodo] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_HIS_HistorialAcademico_NIV_Nivel]
    ON [dbo].[HIS_HistorialAcademico]([Id_Nivel] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_HIS_HistorialAcademico_MAT_Materia]
    ON [dbo].[HIS_HistorialAcademico]([Id_Materia] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_HIS_HistorialAcademico_CUR_CursoLectivo]
    ON [dbo].[HIS_HistorialAcademico]([Id_CursoLectivo] ASC);

