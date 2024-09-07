create proc DeleteInsurance
@codein int
AS
Delete From Insurance where CodeIn=@codein
go