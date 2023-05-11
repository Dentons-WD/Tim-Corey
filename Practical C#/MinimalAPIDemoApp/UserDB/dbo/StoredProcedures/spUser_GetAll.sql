create procedure [dbo].[spUser_GetAll]
as
begin
	select Id, FirstName, LastName
	from dbo.[User];
end