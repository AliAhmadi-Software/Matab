create proc SearchMonshiWDateE
@DateE nvarchar(50)
AS
Select * from Monshi where DateE=@DateE
Go 