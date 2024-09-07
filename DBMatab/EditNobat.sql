create proc EditNobat
@nobat int,
@date nvarchar(50),
@name nvarchar(50),
@namek nvarchar(50),
@tel nvarchar(50),
@tozih nvarchar(MAX)
AS
update Nobat set DateN=@date,Name=@name,NameK=@namek,Tel=@tel,tozih=@tozih where Nobat=@nobat
go