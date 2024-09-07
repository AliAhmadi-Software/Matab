create proc ReportPay
@Date1 nvarchar(50),
@Date2 nvarchar(50)
AS
Begin
Select * from Pay where (DateS >= @Date1) AND (DateS <= @Date2)
order by DateS
End
Go