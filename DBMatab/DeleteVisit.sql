create proc DeleteVisit
@idvisit int
AS
delete from Visit where IDVisit=@idvisit
GO