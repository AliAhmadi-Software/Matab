create proc MyBackup
@path nvarchar(500)
AS
backup Database MatabDB to disk =@path with Init
Go 