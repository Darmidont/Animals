CREATE TABLE [dbo].[KindOfAnimal]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	[Name] NVARCHAR(200) NOT NULL,
	[PlannedNumber] INT NOT NULL,
	[CurrentNumber] INT default(0),
	[Description] NVARCHAR(500)	
)
