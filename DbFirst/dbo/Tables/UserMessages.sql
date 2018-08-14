CREATE TABLE [dbo].[UserMessages] (
    [UserId]    UNIQUEIDENTIFIER NOT NULL,
    [MessageId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [FK_UserMessages_Messages] FOREIGN KEY ([MessageId]) REFERENCES [dbo].[Messages] ([Id]),
    CONSTRAINT [FK_UserMessages_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

