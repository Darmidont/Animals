CREATE PROCEDURE [dbo].[dbo.spAddParticularAnimal]

	    --Id 
		-- AnimalTypeId
		 @Name NVARCHAR(200),
		 @HasCollar BIT,
		 @IsAlive BIT,
         @HeartRhythms INT,
         @CaloriesBurned INT,
         @BreathingRate INT,
	     @LastWeight INT,
		 @CurrentNumberOfAnimals INT,
	     @Description NVARCHAR(200)
AS
BEGIN
INSERT INTO dbo.[ParticularAnimalProperties] 
([Name], [HasCollar], [IsAlive], [HeartRhythms], [CaloriesBurned], [BreathingRate], [LastWeight],[CurrentNumberOfAnimals],[Description])
VALUES (@Name, @HasCollar, @IsAlive, @HeartRhythms, @CaloriesBurned, @BreathingRate, @LastWeight,@CurrentNumberOfAnimals, @Description)
end