create proc EditFileS
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
@recipe nvarchar(MAX)
AS
Update FileSick set DateF=@datef,Name=@name,NameK=@namek,DateB=@dateb,Sex=@sex,DateNow=@datenow,DateAfter=@dateafter,NameIn=@namein,PriceIn=@pricein,illPast=@illpast,illNow=@illnow,Recipe=@recipe where CodeF=@codef
Go