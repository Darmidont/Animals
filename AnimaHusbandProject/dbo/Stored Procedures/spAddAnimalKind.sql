CREATE PROCEDURE [dbo].[spAddAnimalKind]
    @Name nvarchar(200),
	@PlannedNumber nvarchar(200),
	@CurrentNumber nvarchar(200),
	@Description nvarchar(500)
AS
BEGIN
INSERT INTO dbo.[KindAnimalsProperties] 
([Name], [PlannedNumber], [CurrentNumber], [Description])
VALUES (@Name, @PlannedNumber, @CurrentNumber, @Description)
END
