create proc DeleteFileS
@codef int
AS
Delete from FileSick where CodeF=@codef
GO