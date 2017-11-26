CREATE TABLE [dbo].[AnimalProperties]
(
	[Id] INT NOT NULL PRIMARY KEY  IDENTITY (1, 1),
	[Name] nvarchar(100) not null,
	[Description] nvarchar(500)
)
