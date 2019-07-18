CREATE TABLE [dbo].[REL_CursoLectivo_Institucion] (
    [IdCursoLectivo] INT NOT NULL,
    [IdInstitucion]  INT NOT NULL,
    CONSTRAINT [PK_REL_CursoLectivo_Institucion] PRIMARY KEY CLUSTERED ([IdCursoLectivo] ASC, [IdInstitucion] ASC),
    CONSTRAINT [FK_REL_CursoLectivo_Institucion_CAT_CursoLectivo] FOREIGN KEY ([IdCursoLectivo]) REFERENCES [dbo].[CAT_CursoLectivo] ([Id]),
    CONSTRAINT [FK_REL_CursoLectivo_Institucion_LIS_Instituciones] FOREIGN KEY ([IdInstitucion]) REFERENCES [dbo].[LIS_Instituciones] ([Id])
);

