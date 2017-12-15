CREATE PROCEDURE [dbo].[spGetAnimalsbyAnimalKindId]
@AnimalKindId int
as begin
select * from dbo.AnimalProperties p where p.AnimalKindId = @AnimalKindId
end