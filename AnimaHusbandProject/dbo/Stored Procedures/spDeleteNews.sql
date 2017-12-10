CREATE PROCEDURE [dbo].[spDeleteNews]
	@Name NVARCHAR(200),
	@Message NVARCHAR(1000)


AS
BEGIN
	DELETE FROM [dbo].[NewsIntoBoard] WHERE [Name] = @Name

	--[Name] = @Name,
--	[Message] = @Message
	--([Name], [Message])
  --  VALUES (@Name,@Message)
END