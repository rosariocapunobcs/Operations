--DROP TABLE [dbo].[Disrupt]

CREATE TABLE [dbo].[Disrupt]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CarrierCode] CHAR(10) NOT NULL, 
    [Number] NCHAR(10) NOT NULL, 
    [Origin] CHAR(10) NOT NULL, 
    [Destination] CHAR(10) NOT NULL, 
    [STD] DATETIME NOT NULL, 
    [STA] DATETIME NOT NULL, 
    [Severity] VARCHAR(50) NOT NULL, 
    [PaxDLOriginal] NUMERIC NOT NULL, 
    [PaxDLLive] NUMERIC NOT NULL, 
    [Reason] VARCHAR(MAX) NULL, 
    [Recovery] NUMERIC NULL, 
    [StaffComms] VARCHAR(MAX) NULL, 
    [CustomerComms] VARCHAR(MAX) NULL, 
    [Event] VARCHAR(50) NOT NULL
)

--INSERT INTO [dbo].[Disrupt] ([Id], [CarrierCode], [Number], [Origin], [Destination], [STD], [STA], [Severity], [PaxDLOriginal], [PaxDLLive], [Reason], [Recovery], [StaffComms], [CustomerComms], [Event]) VALUES (1, N'5J        ', N'720       ', N'MNL       ', N'SIN       ', N'2016-09-27 00:00:00', N'2016-09-27 00:00:00', N'low', CAST(12 AS Decimal(18, 0)), CAST(13 AS Decimal(18, 0)), N'Test', CAST(1 AS Decimal(18, 0)), N'mobile', N'email', N'cancellation')
--INSERT INTO [dbo].[Disrupt] ([Id], [CarrierCode], [Number], [Origin], [Destination], [STD], [STA], [Severity], [PaxDLOriginal], [PaxDLLive], [Reason], [Recovery], [StaffComms], [CustomerComms], [Event]) VALUES (2, N'TR        ', N'714       ', N'MNL       ', N'SIN       ', N'2016-09-28 00:00:00', N'2016-09-28 00:00:00', N'medium', CAST(14 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), N'test2', CAST(2 AS Decimal(18, 0)), N'fixed', N'mobile', N'delay')
