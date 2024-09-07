create proc SelectNobatWDateN
@daten nvarchar(50)
AS
Select * from Nobat where DateN=@daten
GO