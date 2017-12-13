create procedure [dbo].[spGetAnimalTypes]
as
begin
select 	
	[Id],
	[Name],
	[PlannedNumber] PlannedNumberOfAnimals,
	[CurrentNumber] CurrentNumberOfAnimals,
	[Description] DescriptionOFAnimals
	from dbo.[KindOfAnimal]
end
