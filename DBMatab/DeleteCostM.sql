create proc DeleteCostM
@code int
AS
Delete from CostM where CodeCostM=@code
Go