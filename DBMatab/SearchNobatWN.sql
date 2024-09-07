create proc SearchNobatWN
@nobat int
AS
Select * from Nobat where Nobat=@nobat
Go
