create proc SelectFileSWN
@namek nvarchar(50)
AS
Select * from FileSick where NameK=@namek
Go