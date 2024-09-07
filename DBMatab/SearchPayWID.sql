create proc SearchPayWID
@ID int
AS
Select * from Pay where IDMonshi=@ID
GO