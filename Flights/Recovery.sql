CREATE TABLE [dbo].[Recovery]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Policy] VARCHAR(MAX) NOT NULL, 
    [Plan] VARCHAR(MAX) NULL
)
