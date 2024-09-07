create proc SelectCostMWD
@datec nvarchar(50)
AS
Select * from CostM where DateC=@datec
Go 