CREATE TABLE [dbo].[LIS_CuotasBeca] (
    [Id]                INT             IDENTITY (1, 1) NOT NULL,
    [Id_BecaEstudiante] INT             NULL,
    [Id_Donador]        INT             NULL,
    [Descripcion]       VARCHAR (300)   NULL,
    [Monto]             DECIMAL (18, 2) NULL,
    [Pendiente]         BIT             NOT NULL,
    [Activa]            BIT             NOT NULL,
    [Anulada]           BIT             NOT NULL,
    [Usuario]           VARCHAR (50)    NULL,
    [Fecha]             VARCHAR (50)    NULL,
    CONSTRAINT [PK_LIS_CuotasBeca] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LIS_CuotasBeca_LIS_BecaEstudiante] FOREIGN KEY ([Id_BecaEstudiante]) REFERENCES [dbo].[LIS_BecaEstudiante] ([Id]),
    CONSTRAINT [FK_LIS_CuotasBeca_LIS_Donador] FOREIGN KEY ([Id_Donador]) REFERENCES [dbo].[LIS_Donador] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_LIS_CuotasBeca_LIS_BecaEstudiante]
    ON [dbo].[LIS_CuotasBeca]([Id_BecaEstudiante] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_LIS_CuotasBeca_LIS_Donador]
    ON [dbo].[LIS_CuotasBeca]([Id_Donador] ASC);

