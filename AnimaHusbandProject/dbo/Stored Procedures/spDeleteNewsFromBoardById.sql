CREATE PROCEDURE [dbo].[spDeleteNewsFromBoardById]

@Id int
as
begin
 delete from dbo.[NewsIntoBoard] 
 where Id = @Id
end