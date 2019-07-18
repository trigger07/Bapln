CREATE TABLE [dbo].[LIS_Responsable] (
    [Id]                 INT             NOT NULL,
    [Nombre]             NVARCHAR (50)   NULL,
    [PrimerApellido]     NVARCHAR (50)   NULL,
    [SegundoApellido]    NVARCHAR (50)   NULL,
    [Cedula]             NVARCHAR (30)   NULL,
    [Telefono]           NVARCHAR (50)   NULL,
    [FechaNacimiento]    DATETIME        NULL,
    [Direccion]          NVARCHAR (400)  NULL,
    [Email]              NVARCHAR (50)   NULL,
    [Trabajo]            NVARCHAR (100)  NULL,
    [IngresoMensual]     DECIMAL (18, 2) NULL,
    [Oficio]             NVARCHAR (50)   NULL,
    [Escolaridad]        NCHAR (10)      NULL,
    [Conocimientos]      NVARCHAR (250)  NULL,
    [Id_EstadoCivil]     INT             NULL,
    [Id_Nacionalidad]    INT             NULL,
    [Id_TipoResponsable] INT             NULL,
    CONSTRAINT [PK_LIS_Responsable] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LIS_Responsable_CAT_EstadoCivil] FOREIGN KEY ([Id_EstadoCivil]) REFERENCES [dbo].[CAT_EstadoCivil] ([Id]),
    CONSTRAINT [FK_LIS_Responsable_CAT_Nacionalidad] FOREIGN KEY ([Id_Nacionalidad]) REFERENCES [dbo].[CAT_Nacionalidad] ([Id]),
    CONSTRAINT [FK_LIS_Responsable_CAT_TipoResponsable] FOREIGN KEY ([Id_TipoResponsable]) REFERENCES [dbo].[CAT_TipoResponsable] ([Id])
);

