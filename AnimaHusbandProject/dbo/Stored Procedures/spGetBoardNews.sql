CREATE PROCEDURE [dbo].[spGetBoardNews]
AS
begin
select 	
	[Id],
    [Name],
	[Message],
	[Date]
	from dbo.[NewsIntoBoard]
end