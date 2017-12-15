CREATE PROCEDURE [dbo].[spGetAnimalTypesById]
@Id int
as
begin
 SELECT 
    [Id],
	[Name],
	[PlannedNumber] PlannedNumberOfAnimals,
	[CurrentNumber] CurrentNumberOfAnimals,
	[Description] DescriptionOFAnimals
 FROM dbo.[KindOfAnimal] 
 where Id = @Id
end