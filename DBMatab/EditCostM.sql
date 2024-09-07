create proc EditCostM
@code int,
@explain nvarchar(100),
@price int,
@datec nvarchar(50),
@name nvarchar(50),
@tozih nvarchar(MAX)
AS
update CostM set ExplainC=@explain,Price=@price,DateC=@datec,Name=@name,Tozih=@tozih where CodeCostM=@code
Go