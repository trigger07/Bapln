CREATE TABLE [dbo].[HIS_HistorialAportes] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [Id_Donador]      INT             NOT NULL,
    [Monto]           DECIMAL (18, 2) NOT NULL,
    [Anulada]         BIT             NOT NULL,
    [Aprobada]        BIT             NOT NULL,
    [UsuarioRegistro] VARCHAR (50)    NOT NULL,
    [FechaRegistro]   DATETIME        NOT NULL,
    CONSTRAINT [PK_HIS_HistorialAportes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_HIS_HistorialAportes_LIS_Donador] FOREIGN KEY ([Id_Donador]) REFERENCES [dbo].[LIS_Donador] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_HIS_HistorialAportes_LIS_Donador]
    ON [dbo].[HIS_HistorialAportes]([Id_Donador] ASC);

