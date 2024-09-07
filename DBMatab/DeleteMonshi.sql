create proc DeleteMonshi
@idmonshi int
AS
delete from Monshi where IDMonshi=@idmonshi
Go