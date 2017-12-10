CREATE PROCEDURE [dbo].[spGetListOfParticularAnimals]
as
begin
select 	
	[Id],
    [AnimalKindId],
	[HasCollar],
	[Name],
	[IsAlive],
	[HeartRhythms],
	[CaloriesBurnedPerDay],
	[BreathingRatePerMinute].
	[LastWeight].
	[Description]
	from dbo.[AnimalProperties]
end