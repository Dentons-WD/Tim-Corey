create procedure [dbo].[spUser_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
as
begin
	update dbo.[User]
	set FirstName = @FirstName, LastName = @LastName
	where Id = @Id;
end