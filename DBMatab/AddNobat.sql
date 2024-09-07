USE [MatabDB]
GO
/****** Object:  StoredProcedure [dbo].[AddNobat]    Script Date: 3/6/2020 5:14:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[AddNobat]
@nobat int,
@date nvarchar(50),
@name nvarchar(50),
@namek nvarchar(50),
@tel nvarchar(50),
@tozih nvarchar(MAX),
@result int output
AS
if(EXISTS(select * from Nobat where Nobat=@nobat))
set @result=1
else
begin
set @result=0
insert into Nobat (Nobat,DateN,Name,NameK,Tel,tozih) 
values (@nobat,@date,@name,@namek,@tel,@tozih)
End
