CREATE TABLE [dbo].[LIS_Donador] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [Nombre]          NVARCHAR (50)   NOT NULL,
    [PrimerApellido]  NVARCHAR (200)  NOT NULL,
    [SegundoApellido] NVARCHAR (200)  NULL,
    [Email]           NVARCHAR (500)  NULL,
    [TelefonoLocal]   NVARCHAR (8)    NULL,
    [TelefonoMovil]   NVARCHAR (8)    NULL,
    [Id_Periodicidad] INT             NOT NULL,
    [MontoAporte]     DECIMAL (19, 4) NOT NULL,
    [Id_Nacionalidad] INT             NOT NULL,
    [FechaNacimiento] DATETIME        NULL,
    [Activo]          BIT             NOT NULL,
    CONSTRAINT [PK_LIS_Donador] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DON_Donadores_NAC_Nacionalidad] FOREIGN KEY ([Id_Nacionalidad]) REFERENCES [dbo].[CAT_Nacionalidad] ([Id]),
    CONSTRAINT [FK_LIS_Donador_CAT_PeriodicidadPago] FOREIGN KEY ([Id_Periodicidad]) REFERENCES [dbo].[CAT_PeriodicidadPago] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_LIS_Donador_CAT_PeriodicidadPago]
    ON [dbo].[LIS_Donador]([Id_Periodicidad] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_DON_Donadores_NAC_Nacionalidad]
    ON [dbo].[LIS_Donador]([Id_Nacionalidad] ASC);

