CREATE TABLE [dbo].[AnimalTypes]
(
	[Id] INT NOT NULL PRIMARY KEY  IDENTITY (1, 1),
	[Name] nvarchar(200),
	[IsAlive] bit not null
)
