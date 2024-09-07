create proc SelectFileSWD
@dateafter nvarchar(50)
AS
Select * from FileSick where DateAfter=@dateafter
Go