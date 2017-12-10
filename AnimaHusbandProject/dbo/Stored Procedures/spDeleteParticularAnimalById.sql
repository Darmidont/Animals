CREATE PROCEDURE [dbo].[spDeletePaticularAnimalById]
@Id int
as
begin
 delete from dbo.[AnimalProperties] 
 where Id = @Id
END