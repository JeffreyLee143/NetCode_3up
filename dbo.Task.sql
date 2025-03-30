CREATE TABLE [dbo].[Task] (
    [TaskId]      INT           identity(1,1) NOT NULL,
    [Title]       VARCHAR (20) NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    [Budget]      INT          NOT NULL,
    [DueDate]     DATETIME     NOT NULL, 
    CONSTRAINT [PK_Task] PRIMARY KEY ([TaskId]),
);
