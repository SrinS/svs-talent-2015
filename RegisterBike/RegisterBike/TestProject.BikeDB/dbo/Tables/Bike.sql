CREATE TABLE [dbo].[Bike] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [Model]            NVARCHAR (200) NULL,
    [Tip]              NVARCHAR (200) NULL,
    [SeriskiBroj]      NVARCHAR (200) NULL,
    [Grad]             NVARCHAR (200) NULL,
    [Flag]             NVARCHAR (200) NULL,
    [BrojNaBrizini]    INT            NULL,
    [Boja1]            NVARCHAR (200) NULL,
    [Boja2]            NVARCHAR (200) NULL,
    [MaterijalNaRamka] NVARCHAR (200) NULL,
    CONSTRAINT [PK_Bike] PRIMARY KEY CLUSTERED ([Id] ASC)
);

