create proc SelectCostMWC
@code int
AS
Select * from CostM where CodeCostM=@code
GO