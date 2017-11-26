CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL   IDENTITY (1, 1) PRIMARY KEY,
	[FirstName] nvarchar(200) not null,
	[LastName] nvarchar(200),
	[Email] nvarchar(200) not null,
	[Login] nvarchar(200) not null,
	[Description] nvarchar(500)
)
