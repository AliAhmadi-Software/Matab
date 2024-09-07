create proc SumV
@Date1 nvarchar(50),
@Date2 nvarchar(50)
AS
Select SUM (PayV) from Visit where DateV between @Date1 AND @Date2
Go