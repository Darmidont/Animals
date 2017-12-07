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
	     @DescriptionOFAnimals NVARCHAR(200)
AS
BEGIN
INSERT INTO dbo.[ParticularAnimalProperties] 
([Name], [HasCollar], [IsAlive], [HeartRhythms], [CaloriesBurned], [BreathingRate], [LastWeight],[CurrentNumberOfAnimals],[DescriptionOFAnimals])
VALUES (@Name, @HasCollar, @IsAlive, @HeartRhythms, @CaloriesBurned, @BreathingRate, @LastWeight,@CurrentNumberOfAnimals, @DescriptionOFAnimals)
end