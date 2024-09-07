create proc EditKarbar
@username nvarchar(100),
@pasword nvarchar(50),
@acess nvarchar(50)
AS
update Karbar set Pasword=@pasword,Acess=@acess where UserName=@username
Go 