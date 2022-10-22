CREATE PROCEDURE [dbo].[spUser_Delete]
	@id int
AS
begin
	delete
    from dbo.[User]
	where id = @id;
end
