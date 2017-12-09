CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL   IDENTITY (1, 1) PRIMARY KEY,
	[FirstName] nvarchar(200) not null,
	[LastName] nvarchar(200),
	[Email] nvarchar(200) not null,
	[Login] nvarchar(200) not null,
    [Password] nvarchar(200) NOT NULL, 
	[Description] nvarchar(500), 
    [CreatedDate] DATETIME NOT NULL, 
	[IsAdmin] bit default(0)
)
