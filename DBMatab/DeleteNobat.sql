create proc DeleteNobat
@nobat int
AS
Delete from Nobat where Nobat=@nobat
Go