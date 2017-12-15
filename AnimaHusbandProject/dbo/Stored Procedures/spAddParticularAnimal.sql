CREATE PROCEDURE [dbo].[spAddParticularAnimal]
		@TypeId int,
		 @Name NVARCHAR(200),
		 @HasCollar BIT,
	     @LastWeight INT,
	     @Description NVARCHAR(200)
AS
BEGIN
INSERT INTO dbo.[AnimalProperties] 
(AnimalKindId, [Name], [HasCollar], [IsAlive], [LastWeight],[Description])
VALUES (@TypeId, @Name, @HasCollar, 1,  @LastWeight,  @Description)
end