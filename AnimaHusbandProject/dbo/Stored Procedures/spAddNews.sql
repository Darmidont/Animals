CREATE PROCEDURE [dbo].[spAddNews]
       
	   @Name NVARCHAR(200),
	   @Message NVARCHAR(1000)
AS
BEGIN
INSERT INTO [dbo.NewsIntoBoard]
	([Name], [Message])
VALUES (@Name, @Message)
END
