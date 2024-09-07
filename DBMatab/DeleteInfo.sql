create proc DeleteInfo
@id int
AS
delete from Info where id=@id
Go