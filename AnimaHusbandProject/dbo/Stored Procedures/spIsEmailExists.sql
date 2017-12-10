create procedure [dbo].[spIsEmailExists]
@Email nvarchar(200)
as
begin
	declare @Result bit = 0;

	select top 1 @Result = 1
	from dbo.Users
	where Email = @Email

	select isnull(@Result, 0)
end