CREATE PROCEDURE [dbo].[spAddUser]
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(200),
	@Login nvarchar(200),
	@Password nvarchar(200),
	@Description nvarchar(500)
AS
BEGIN
UPDATE dbo.[Users] 
([FirstName], [LastName], [Email], [Login], [Password], [Description])
VALUES (@FirstName, @LastName, @Email, @Login, @Password, @Description)
SELECT SCOPE_IDENTITY() -- UserId
END
