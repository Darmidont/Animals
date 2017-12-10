CREATE PROCEDURE [dbo].[spLoginUser]
	@Email NVARCHAR(200),
	@Password NVARCHAR(200)
AS 
begin
	declare @Result bit = 0;

	select top 1 @Result = 1
	from dbo.Users
	where Email = @Email and Password = @Password

	select isnull(@Result, 0)
end