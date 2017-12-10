CREATE PROCEDURE [dbo].[spDeleteUserByAdmin]
@Id int
as
begin
 delete from dbo.[Users] 
 where Id = @Id
end