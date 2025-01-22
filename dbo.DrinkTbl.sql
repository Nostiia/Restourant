
CREATE TABLE [dbo].[DrinkTbl] (
    [DCode]     INT         IDENTITY (100, 1) NOT NULL,
    [DName]     NCHAR (150) NOT NULL,
    [DPrice]    INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([DCode] ASC)
);
