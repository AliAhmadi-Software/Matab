create proc SelectVisitWID
@idvisit int
AS
Select * from Visit where IDVisit=@idvisit
Go