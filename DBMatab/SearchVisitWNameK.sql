create proc SearchVisitWNameK
@namek nvarchar(50)
AS
Select * from Visit where NameK=@namek
Go