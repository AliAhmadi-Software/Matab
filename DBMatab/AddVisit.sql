create proc AddVisit
@idvisit int,
@datev nvarchar(50),
@name nvarchar(50),
@namek nvarchar(50),
@namein nvarchar(50),
@pricein int,
@names nvarchar(50),
@prices int,
@payv int,
@recipe nvarchar(MAX),
@result int output
AS
if(EXISTS(select * from Visit where IDVisit=@idvisit))
set @result=1
else
begin
set @result=0
insert into Visit (IDVisit,DateV,Name,NameK,NameIn,PriceIn,NameS,PriceS,PayV,Recipe)
values (@idvisit,@datev,@name,@namek,@namein,@pricein,@names,@prices,@payv,@recipe)
END