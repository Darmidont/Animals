CREATE PROCEDURE [dbo].[spUpdateNews]
	@Id int,
	@Name nvarchar(200),
	@Message nvarchar(500),
	@Email nvarchar(200),
	@Login nvarchar(200),
	@Password nvarchar(200),
	@Description nvarchar(500)
as
begin
	 update u 
	 set 
	 u.Name  = @Name,
	 u.Message = @Message
	 from dbo.NewsIntoBoard u
	 where u.Id = @Id 
end