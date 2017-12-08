create procedure [dbo].[spGetAnimalTypes]
as
begin
select 	
	[Id],
	[Name],
	[PlannedNumber],
	[CurrentNumber],
	[Description]
	from dbo.[KindOAnimal]
end
