CREATE PROCEDURE [dbo].[spUser_Insert]
	@firstname nvarchar(50),
	@lastName nvarchar(50)
AS
	begin
	    Insert into dbo.[User] (FirstName, LastName)
		values (@firstname, @lastName);

	end
