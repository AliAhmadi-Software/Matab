create proc AddPay
@Idmonshi int,
@namekh nvarchar(50),
@salary int,
@date nvarchar(50),
@tozih nvarchar(MAX)
AS 
insert into Pay (IDMonshi,NameK,Salary,DateS,Tozih) values (@Idmonshi,@namekh,@salary,@date,@tozih)
Go