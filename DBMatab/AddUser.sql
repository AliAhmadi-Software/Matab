create proc AddUser
@username nvarchar(100),
@pasword nvarchar(50),
@acess nvarchar(50),
@result int output
AS
if(EXISTS(select * from Karbar where UserName=@username))
set @result=1
else
begin
set @result=0
insert into Karbar(UserName,Pasword,Acess) values (@username,@pasword,@acess)
end