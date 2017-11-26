CREATE TABLE [dbo].[Animals]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	[AnimalTypeId] int not null,
	[Name] nvarchar(100) not null,
	[Description] nvarchar(500),
	constraint FK_Animal_AnimalType foreign key ([AnimalTypeId]) references dbo.AnimalTypes(Id)
)

