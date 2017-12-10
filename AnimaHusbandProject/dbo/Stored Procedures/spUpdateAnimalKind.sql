CREATE PROCEDURE [dbo].[spUpdateAnimalKind]
@Id INT,
@Name nvarchar(200),
@PlannedNumber int,
@Description NVARCHAR(500)
as
begin
	 update u 
	 set 
	 u.Name  = @Name,
	 u.PlannedNumber = @PlannedNumber,
	 u.Description = @Description
	 from dbo.KindOfAnimal u
	 where u.Id = @Id 
end