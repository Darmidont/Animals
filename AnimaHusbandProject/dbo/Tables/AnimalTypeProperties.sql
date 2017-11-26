CREATE TABLE [dbo].[AnimalTypeProperties]
(
	[Id] int not null PRIMARY KEY  IDENTITY (1, 1),
	[AnimalTypeId] INT NOT NULL,
	[PropertyId] int not null,
	constraint FK_AnimalTypeProperties_AnimalType foreign key ([AnimalTypeId]) references dbo.AnimalTypes(Id),
	constraint FK_AnimalTypeProperties_AnimalProperties foreign key ([PropertyId]) references dbo.[AnimalProperties](Id)
)
