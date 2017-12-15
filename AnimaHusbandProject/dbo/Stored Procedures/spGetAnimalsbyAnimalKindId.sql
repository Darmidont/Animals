CREATE PROCEDURE [dbo].[spGetAnimalsbyAnimalKindId]
@AnimalKindId int
as begin
select  Id,
		 AnimalKindId AnimalTypeId,
		 [Name],
		 IsAlive,
		 HasCollar,
		HeartRhythms,
		CaloriesBurnedPerDay CaloriesBurned,
		BreathingRatePerMinute BreathingRate,
		LastWeight,
		[Description] from dbo.AnimalProperties p where p.AnimalKindId = @AnimalKindId
end