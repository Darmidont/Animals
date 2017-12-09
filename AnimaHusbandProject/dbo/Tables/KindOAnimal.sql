CREATE TABLE [dbo].[KindOAnimal]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	--[AnimalId] int not null,
	--[AnimalTypePropertyId] int not null,
	[Name] NVARCHAR(200) NOT NULL,
	[PlannedNumber] INT NOT NULL,
	[CurrentNumber] INT NOT NULL,
	[Description] NVARCHAR(500)
	--constraint FK_ConcreteAnimalProperties_AnimalTypeProperties foreign key ([AnimalTypePropertyId]) references dbo.[AnimalTypeProperties](Id)
)
