if not exists (select 1 from dbo.[User])

begin
    insert into dbo.[User] (FirstName, LastName)
    values ('Tosin', 'Idowu'),
    ('Tim', 'Corey'),
    ('John', 'Snow'),
    ('Mary', 'Poppins');

end