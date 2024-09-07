create proc SearchMonshiWID
@Id int
AS
Select * from Monshi where IDMonshi=@Id
Go