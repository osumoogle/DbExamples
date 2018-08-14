CREATE TABLE [dbo].[Users] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [FirstName] NVARCHAR (100)   NOT NULL,
    [LastName]  NVARCHAR (100)   NOT NULL,
    [UserName]  NVARCHAR (100)   NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

