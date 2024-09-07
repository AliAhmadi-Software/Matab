create proc EditInfo
@id int,
@codedoc nvarchar(50),
@namedoc nvarchar(50),
@namematab nvarchar(50),
@tel nvarchar(50),
@mobile nvarchar(50),
@adres nvarchar(50)
AS
update Info set CodeDoc=@codedoc,Namedoc=@namedoc,NameMatab=@namematab,Tel=@tel,Mobile=@mobile,Adres=@adres
where id=@id
go