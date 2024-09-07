create proc DeleteService
@codes int
AS
Delete from ServiceM where CodeS=@codes
Go