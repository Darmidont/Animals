CREATE PROCEDURE [dbo].[dbo.spAddParticularAnimal]
		 @Name NVARCHAR(200),
		 @HasCollar BIT,
	     @LastWeight INT,
	     @Description NVARCHAR(200)
AS
BEGIN
INSERT INTO dbo.[ParticularAnimalProperties] 
([Name], [HasCollar], [IsAlive], [LastWeight],[Description])
VALUES (@Name, @HasCollar, 1,  @LastWeight,  @Description)
end