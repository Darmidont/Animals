CREATE TABLE [dbo].[ConcreteAnimalProperties]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	[AnimalId] int not null,
	[AnimalTypePropertyId] int not null,
	[Value] nvarchar(100),
	constraint FK_ConcreteAnimalProperties_AnimalTypeProperties foreign key ([AnimalTypePropertyId]) references dbo.[AnimalTypeProperties](Id)
)
