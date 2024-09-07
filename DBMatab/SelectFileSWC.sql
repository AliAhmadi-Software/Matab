create proc SelectFileSWC
@codef int
AS
Select * from FileSick where CodeF=@codef
Go