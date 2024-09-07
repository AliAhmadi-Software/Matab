create proc AddFileSick
@codef int,
@datef nvarchar(50),
@name nvarchar(50),
@namek nvarchar(50),
@dateb nvarchar(50),
@sex nvarchar(50),
@datenow nvarchar(50),
@dateafter nvarchar(50),
@namein nvarchar(50),
@pricein int,
@illpast nvarchar(200),
@illnow nvarchar(200),
@recipe nvarchar(MAX),
@result int output
AS
if(EXISTS(select * from FileSick where CodeF=@codef))
set @result=1
else
begin
set @result=0
insert into FileSick (CodeF,DateF,Name,NameK,DateB,Sex,DateNow,DateAfter,NameIn,PriceIn,illPast,illNow,Recipe) 
values (@codef,@datef,@name,@namek,@dateb,@sex,@datenow,@dateafter,@namein,@pricein,@illpast,@illnow,@recipe)
End