CREATE TABLE [dbo].[Task] (
    [TaskId]      INT          NOT NULL,
    [Title]       VARCHAR (20) NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    [Budget]      INT          NOT NULL,
    [DueDate]     DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([TaskId] ASC)
);

