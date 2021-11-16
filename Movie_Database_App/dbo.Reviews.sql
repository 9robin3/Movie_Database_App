CREATE TABLE [dbo].[Reviews] (
    [ReviewID]    INT            IDENTITY (1, 1) NOT NULL,
    [UserName]    NVARCHAR (MAX) NULL,
    [MovieID]     INT            NOT NULL,
    [ReviewTitle] NVARCHAR (MAX) NOT NULL,
    [Rating]      INT            NOT NULL,
    [Comment]     NVARCHAR (MAX) NOT NULL,
    [DatePosted]  DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED ([ReviewID] ASC),
    CONSTRAINT [FK_Reviews_Movies_MovieID] FOREIGN KEY ([MovieID]) REFERENCES [dbo].[Movies] ([MovieID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Reviews_MovieID]
    ON [dbo].[Reviews]([MovieID] ASC);

