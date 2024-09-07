create proc AddInfo
@codedoc nvarchar(50),
@namedoc nvarchar(50),
@namematab nvarchar(50),
@tel nvarchar(50),
@mobile nvarchar(50),
@adres nvarchar(50)
AS
insert into Info (CodeDoc,Namedoc,NameMatab,Tel,Mobile,Adres) values (@codedoc,@namedoc,@namematab,@tel,@mobile,@adres)
Go