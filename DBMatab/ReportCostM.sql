create proc ReportCostM
@Date1 nvarchar(50),
@Date2 nvarchar(50)
AS
Begin
Select * from CostM where (DateC >= @Date1) AND (DateC <= @Date2)
order by DateC
End 