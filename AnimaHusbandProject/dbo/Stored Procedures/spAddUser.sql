﻿CREATE PROCEDURE [dbo].[spAddUser]
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(200),
	@Login nvarchar(200),
	@Description nvarchar(500)
AS
BEGIN
INSERT INTO dbo.[User] 
(firstname, lastname, email, login, description)
VALUES (@FirstName, @LastName, @Email, @Login, @Description)
END