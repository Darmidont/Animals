CREATE PROCEDURE [dbo].[spCheckUser]
@Email nvarchar(200),
@Password nvarchar(200)
as
begin
select top 1 * from dbo.Users u where u.Email = @Email and u.Password = @password
end