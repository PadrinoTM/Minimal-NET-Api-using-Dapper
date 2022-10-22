CREATE PROCEDURE [dbo].[spUser_Update]
	@id int,
	@firstname nvarchar(50),
	@lastname nvarchar (50)
AS
begin
   update dbo.[User]
 set FirstName = @firstname, LastName = @lastname
 where Id = @id;

end
