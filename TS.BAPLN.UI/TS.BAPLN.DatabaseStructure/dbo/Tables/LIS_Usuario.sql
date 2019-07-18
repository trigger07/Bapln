CREATE TABLE [dbo].[LIS_Usuario] (
    [Id_Usuario] NVARCHAR (50)  NOT NULL,
    [Contraseña] NVARCHAR (20)  NOT NULL,
    [Nombre]     NVARCHAR (200) NOT NULL,
    [Puesto]     NVARCHAR (200) NULL,
    CONSTRAINT [PK_LIS_Usuario] PRIMARY KEY CLUSTERED ([Id_Usuario] ASC)
);

