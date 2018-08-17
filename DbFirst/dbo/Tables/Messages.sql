﻿CREATE TABLE [dbo].[Messages] (
    [Id]    UNIQUEIDENTIFIER NOT NULL,
    [From]  NVARCHAR (100)   NOT NULL,
    [To]    NVARCHAR (100)   NOT NULL,
    [Title] NVARCHAR (50)    NOT NULL,
    [Body]  NVARCHAR (MAX)   NOT NULL,
    [UserId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Messages_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
);

