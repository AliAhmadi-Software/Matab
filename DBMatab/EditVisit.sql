create proc EditVisit
@idvisit int,
@datev nvarchar(50),
@name nvarchar(50),
@namek nvarchar(50),
@namein nvarchar(50),
@pricein int,
@names nvarchar(50),
@prices int,
@payv int,
@recipe nvarchar(MAX)
AS
update Visit set DateV=@datev,Name=@name,NameK=@namek,NameIn=@namein,PriceIn=@pricein,NameS=@names,PriceS=@prices,PayV=@payv,Recipe=@recipe 
where IDVisit=@idvisit
Go