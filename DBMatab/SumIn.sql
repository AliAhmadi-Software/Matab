create proc SumIn
@Date1 nvarchar(50),
@Date2 nvarchar(50)
AS
Select SUM (PriceIn) from Visit where DateV Between @Date1 AND @Date2
Go