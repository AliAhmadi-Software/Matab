create proc EditInsurance
@codein int,
@namein nvarchar(100),
@pricein int,
@tozih nvarchar(MAX)
As
update Insurance set NameIn=@namein,PriceIn=@pricein,Tozih=@tozih where CodeIn=@codein
Go