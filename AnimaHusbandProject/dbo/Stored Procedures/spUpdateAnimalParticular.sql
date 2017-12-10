CREATE PROCEDURE [dbo].[spUpdateAnimalParticular]
		@Id int,
		@AnimalKindId INT,
	@HasCollar nvarchar(200),
	@Name nvarchar(200),
	@IsAlive bit,
	--@HeartRhytms int,
	--@CaloriesBurnedPerDay int,
	--@BreathingRatePerMinute int,
	@LastWeight FLOAT,
	@Description nvarchar(500)
as
begin
	 update u 
	 set 

	 u.HasCollar  = @HasCollar,
	 u.Name = @Name,
	 u.IsAlive = @IsAlive,
	 u.LastWeight = @LastWeight,
	 u.Description = @Description
	 from dbo.AnimalProperties u
	 where u.Id = @Id 
	end