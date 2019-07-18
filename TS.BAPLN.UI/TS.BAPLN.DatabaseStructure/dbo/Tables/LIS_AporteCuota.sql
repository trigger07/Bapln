CREATE TABLE [dbo].[LIS_AporteCuota] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [Id_Cuota]  INT NULL,
    [Id_Aporte] INT NULL,
    CONSTRAINT [PK_LIS_AporteCuota] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LIS_AporteCuota_HIS_HistorialAportes] FOREIGN KEY ([Id_Aporte]) REFERENCES [dbo].[HIS_HistorialAportes] ([Id]),
    CONSTRAINT [FK_LIS_AporteCuota_LIS_CuotasBeca] FOREIGN KEY ([Id_Cuota]) REFERENCES [dbo].[LIS_CuotasBeca] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_LIS_AporteCuota_HIS_HistorialAportes]
    ON [dbo].[LIS_AporteCuota]([Id_Aporte] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_LIS_AporteCuota_LIS_CuotasBeca]
    ON [dbo].[LIS_AporteCuota]([Id_Cuota] ASC);

