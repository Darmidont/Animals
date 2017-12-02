CREATE PROCEDURE [dbo].[spDeletePaticularAnimal]
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(200),
	@Login nvarchar(200),
	@Password nvarchar(200),
	@Description nvarchar(500)
	--@CreatedDate DATETIME,
	--@LastLoginDate DATETIME
AS
BEGIN

SET NOCOUNT ON;
IF EXISTS (SELECT Id FROM Users WHERE Email = @Email)
BEGIN 
SELECT -1
END

ELSE IF EXISTS (SELECT Id FROM Users WHERE Login = @Login)
BEGIN
SELECT -2
END

ELSE
BEGIN
DELETE FROM dbo.[Users] 
--([FirstName], [LastName], [Email], [Login], [Password], [Description], [CreatedDate])
--VALUES (@FirstName, @LastName, @Email, @Login, @Password, @Description, GETDATE())

END
END