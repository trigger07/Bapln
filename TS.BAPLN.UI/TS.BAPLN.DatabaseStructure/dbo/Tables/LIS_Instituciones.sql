CREATE TABLE [dbo].[LIS_Instituciones] (
    [Id]            INT            NOT NULL,
    [Nombre]        NVARCHAR (200) NOT NULL,
    [Telefono]      NVARCHAR (20)  NULL,
    [Direccion]     NVARCHAR (500) NULL,
    [EmailContacto] NVARCHAR (200) NULL,
    [WebSite]       NVARCHAR (200) NULL,
    CONSTRAINT [PK_LIS_Instituciones] PRIMARY KEY CLUSTERED ([Id] ASC)
);

