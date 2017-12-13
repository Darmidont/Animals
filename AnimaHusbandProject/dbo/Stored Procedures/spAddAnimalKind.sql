CREATE PROCEDURE [dbo].[spAddAnimalKind]
    @Name nvarchar(200),
	@PlannedNumber int,
	@Description nvarchar(500)
AS
BEGIN
INSERT INTO dbo.[KindAnimalsProperties] 
([Name], [PlannedNumber],  [Description])
VALUES (@Name, @PlannedNumber,  @Description)
END
