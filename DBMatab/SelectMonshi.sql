create proc SelectMonshi
@idmonshi int
AS
select * from Monshi where IDMonshi=@idmonshi
Go