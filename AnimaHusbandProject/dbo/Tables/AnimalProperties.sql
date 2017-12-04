CREATE TABLE [dbo].[AnimalProperties]
(
	[Id] INT NOT NULL PRIMARY KEY  IDENTITY (1, 1),
	[AnimalTypeId] int NOT NULL,
	[Name] nvarchar(100) null,
	[IsAlive] BIT NOT NULL,
	[HeartRhythms] INT NOT NULL,
	[CaloriesBurnedPerDay] INT NOT NULL,
	[BreathingRatePerMinute] INT NOT NULL,
	[LastWeight] FLOAT NOT NULL,
	[Description] nvarchar(500)
)
