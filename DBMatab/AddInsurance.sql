create proc AddInsurance
@codein int,
@namein nvarchar(100),
@pricein int,
@tozih nvarchar(MAX),
@result int output
AS
if(EXISTS(Select * from Insurance where CodeIn=@codein))
set @result=1
else
begin
set @result=0
insert into Insurance(CodeIn,NameIn,PriceIn,Tozih) values (@codein,@namein,@pricein,@tozih)
End 