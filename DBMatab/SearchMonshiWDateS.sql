create proc SearchMonshiWDateS
@DateS nvarchar(50)
AS
Select * from Monshi where DateSalary=@DateS
Go