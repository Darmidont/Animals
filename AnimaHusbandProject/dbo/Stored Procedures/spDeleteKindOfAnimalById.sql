CREATE PROCEDURE [dbo].[spDeleteKindOfAnimalById]

@Id int
as
begin
 delete from dbo.[KindOfAnimal] 
 where Id = @Id
end
