﻿CREATE TABLE [dbo].[PrivateSigningItemGroup] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_PrivateSigningItemGroup] PRIMARY KEY CLUSTERED ([Id] ASC)
);

