CREATE PROCEDURE [dbo].[spGetUsers]

as
begin
select 	
	[Id],
    [FirstName],
	[LastName],
	[Email],
	[Login],
	[Password],
	[Description],
	[CreatedDate].
	[IsAdmin]
	from dbo.[User]
end