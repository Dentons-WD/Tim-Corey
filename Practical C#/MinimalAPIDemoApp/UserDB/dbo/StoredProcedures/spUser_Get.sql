﻿create procedure [dbo].[spUser_Get]
	@Id int
as
begin
	select Id, FirstName, LastName
	from dbo.[User]
	where Id = @Id;
end