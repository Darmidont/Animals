CREATE PROCEDURE [dbo].[spUpdateUser]
	@Id int,
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(200),
	@Login nvarchar(200),
	@Password nvarchar(200),
	@Description nvarchar(500)
as
begin
	 update  u 
	 set 
	 u.FirstName  = @FirstName,
	 u.LastName = @Lastname,
	 u.Email = @Email,
	 u.Login = @Login,
	 u.Password = @Password,
	 u.Description = @Description
	 from dbo.Users u
	 where u.Id = @Id 
end