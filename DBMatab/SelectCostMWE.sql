create proc SelectCostMWE
@explain nvarchar(100)
As
Select * from CostM where ExplainC=@explain
Go