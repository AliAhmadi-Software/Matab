create proc AddCostM
@code int,
@explain nvarchar(100),
@price int,
@datec nvarchar(50),
@name nvarchar(50),
@tozih nvarchar(MAX),
@result int output
AS
if(EXISTS(select * from CostM where CodeCostM=@code))
set @result=1
else
begin
set @result=0
insert into CostM (CodeCostM,ExplainC,Price,DateC,Name,Tozih)
values (@code,@explain,@price,@datec,@name,@tozih)
End