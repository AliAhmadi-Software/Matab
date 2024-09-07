create proc ReportFileS
@dateafter nvarchar(50)
AS
Select Name,NameK,illPast,illNow,DateAfter from FileSick where DateAfter=@dateafter
Go