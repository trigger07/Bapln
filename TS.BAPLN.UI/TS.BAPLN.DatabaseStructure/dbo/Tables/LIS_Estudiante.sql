CREATE TABLE [dbo].[LIS_Estudiante] (
    [Id]               INT             IDENTITY (1, 1) NOT NULL,
    [Nombre]           NVARCHAR (50)   NOT NULL,
    [PrimerApellido]   NVARCHAR (150)  NOT NULL,
    [SegundoApellido]  NVARCHAR (150)  NULL,
    [Carne]            NVARCHAR (20)   NULL,
    [Cedula]           NVARCHAR (20)   NULL,
    [Padre]            NVARCHAR (500)  NULL,
    [Madre]            NVARCHAR (500)  NULL,
    [TelefonoLocal]    NVARCHAR (8)    NULL,
    [TelefonoMovil]    NVARCHAR (8)    NULL,
    [Fotografia]       NVARCHAR (2000) CONSTRAINT [DF_LIS_Estudiante_Fotografia] DEFAULT (N'Default.png') NULL,
    [Direccion]        NVARCHAR (2000) NULL,
    [Email]            NVARCHAR (250)  NULL,
    [Fecha_Nacimiento] DATETIME        NULL,
    [Id_Nacionalidad]  INT             NOT NULL,
    [Activo]           BIT             NOT NULL,
    [Id_Institucion]   INT             NULL,
    CONSTRAINT [PK_LIS_Estudiante] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EST_Estudiante_NAC_Nacionalidad] FOREIGN KEY ([Id_Nacionalidad]) REFERENCES [dbo].[CAT_Nacionalidad] ([Id]),
    CONSTRAINT [FK_LIS_Estudiante_LIS_Instituciones] FOREIGN KEY ([Id_Institucion]) REFERENCES [dbo].[LIS_Instituciones] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_EST_Estudiante_NAC_Nacionalidad]
    ON [dbo].[LIS_Estudiante]([Id_Nacionalidad] ASC);

