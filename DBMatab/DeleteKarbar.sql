create proc DeleteKarbar
@username nvarchar(100)
AS
delete from Karbar where UserName=@username
Go