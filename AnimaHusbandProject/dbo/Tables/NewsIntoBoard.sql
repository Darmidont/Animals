﻿CREATE TABLE [dbo].[NewsIntoBoard]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	[Name] NVARCHAR(200) NOT NULL,
	[Message] NVARCHAR(1000) NOT NULL,
	[Date] DATETIME NOT NULL

)
