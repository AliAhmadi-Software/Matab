create proc EditService
@codes int,
@names nvarchar(100),
@prices int,
@tozih nvarchar(MAX)
AS
update ServiceM set NameS=@names,PriceS=@prices,Tozih=@tozih where CodeS=@codes
Go 