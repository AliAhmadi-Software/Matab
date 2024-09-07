USE [MatabDB]
GO
/****** Object:  StoredProcedure [dbo].[AddMonshi]    Script Date: 3/2/2020 12:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[AddMonshi]
@idmonshi int,
@namemonshi nvarchar(50),
@namek nvarchar(50),
@codem nvarchar(50),
@tel nvarchar(50),
@dateb nvarchar(50),
@datee nvarchar(50),
@salary int,
@datesalary nvarchar(50),
@tozih nvarchar(MAX),
@result int output
AS
if(EXISTS(select * from Monshi where IDMonshi=@idmonshi))
set @result=1
else
begin
set @result=0
insert into Monshi (IDMonshi,NameMonshi,NameK,CodeM,Tel,DataB,DateE,Salary,DateSalary,Tozih) 
values (@idmonshi,@namemonshi,@namek,@codem,@tel,@dateb,@datee,@salary,@datesalary,@tozih)
end