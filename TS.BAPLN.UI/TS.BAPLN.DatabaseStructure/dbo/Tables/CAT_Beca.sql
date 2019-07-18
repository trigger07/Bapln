CREATE TABLE [dbo].[CAT_Beca] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [Descripcion]    NVARCHAR (MAX)  NOT NULL,
    [Id_TipoBeca]    INT             NOT NULL,
    [MontoTotal]     DECIMAL (18, 2) NOT NULL,
    [MontoCuota]     DECIMAL (18, 2) NOT NULL,
    [CantidadCuotas] SMALLINT        NOT NULL,
    [Activa]         BIT             NOT NULL,
    CONSTRAINT [PK_CAT_Beca] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CAT_Beca_CAT_TipoBeca] FOREIGN KEY ([Id_TipoBeca]) REFERENCES [dbo].[CAT_TipoBeca] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_CAT_Beca_CAT_TipoBeca]
    ON [dbo].[CAT_Beca]([Id_TipoBeca] ASC);

