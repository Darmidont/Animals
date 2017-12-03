CREATE PROCEDURE [dbo].[spAddUser]
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(200),
	@Login nvarchar(200),
	@Password nvarchar(200),
	@Description nvarchar(500)
AS
BEGIN
INSERT INTO dbo.[Users] 
([FirstName], [LastName], [Email], [Login], [Password], [Description], [CreatedDate])
VALUES (@FirstName, @LastName, @Email, @Login, @Password, @Description, GETDATE())
SELECT SCOPE_IDENTITY() -- UserId
END
