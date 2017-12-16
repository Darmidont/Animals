CREATE TABLE [dbo].[AnimalProperties]
(
	[Id] INT NOT NULL PRIMARY KEY  IDENTITY (1, 1),
	[AnimalKindId] int NOT NULL,
	[HasCollar] BIT NOT NULL,
	[Name] nvarchar(100) null,
	[IsAlive] BIT NOT NULL,
	[HeartRhythms] INT default(0),
	[CaloriesBurnedPerDay] INT default(0),
	[BreathingRatePerMinute] INT default(0),
	[LastWeight] FLOAT default(0),
	[Description] nvarchar(500),
	constraint FK_AnimalProperties_KindOfAnimal foreign key (AnimalKindId) references dbo.[KindOfAnimal](Id)
)
