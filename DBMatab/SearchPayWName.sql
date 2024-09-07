create proc SearchPayWName
@name nvarchar(50)
AS
Select * from Pay where NameK=@name
Go