CREATE PROCEDURE [dbo].[dbo.spAddParticularAnimal]

	    --Id 
		-- AnimalTypeId
		 @Name,
		 @Alive 
         @HeartRhythms 
         @CaloriesBurned 
         @BreathingRate 
	     @LastWeight
		 @CurrentNumberOfAnimals
	     @DescriptionOFAnimals
AS
BEGIN
INSERT INTO [dbo.spAddParticularAnimal] 

([FirstName], [LastName], [Email], [Login], [Password], [Description])
VALUES (@FirstName, @LastName, @Email, @Login, @Password, @Description)


end