create proc AddService
@codes int,
@names nvarchar(100),
@prices int,
@tozih nvarchar(MAX),
@result int output
AS
if(EXISTS(Select * from ServiceM where CodeS=@codes))
set @result=1
else
begin
set @result=0
insert into ServiceM (CodeS,NameS,PriceS,Tozih) values (@codes,@names,@prices,@tozih)
End
