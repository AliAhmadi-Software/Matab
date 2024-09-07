create proc ReportPayV
@Date1 nvarchar(50),
@Date2 nvarchar(50)
AS
Begin
Select * from Visit where (DateV >= @Date1) AND (DateV <= @Date2)
order by DateV
End