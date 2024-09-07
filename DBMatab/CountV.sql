create proc CountV
@Date1 nvarchar(50),
@Date2 nvarchar(50)
AS
Select COUNT (*) from Visit where DateV between @Date1 AND @Date2
Go