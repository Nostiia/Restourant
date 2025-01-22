CREATE TABLE [dbo].[FoodTbl] (
    [FCode]     INT         IDENTITY (1, 1) NOT NULL,
    [FName]     NCHAR (150) NOT NULL,
    [FCategory] NCHAR (50)  NOT NULL,
    [FPrice]    INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([FCode] ASC)
);

