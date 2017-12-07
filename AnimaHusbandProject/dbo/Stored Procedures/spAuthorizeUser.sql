CREATE PROCEDURE [dbo].[spAuthorizeUser]
	@Login NVARCHAR(200),
	@Password NVARCHAR(200)
AS 
	BEGIN
	INSERT INTO [dbo.NewsIntoBoard]
	([Login], [Password])
VALUES (@Login, @Password)
	--([Login],[Password])
	--VALUES (@Login,@Password)
end