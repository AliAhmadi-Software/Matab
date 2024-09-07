create proc SearchPayWDateS
@DateS nvarchar(50)
AS
Select * from Pay where DateS=@DateS
Go