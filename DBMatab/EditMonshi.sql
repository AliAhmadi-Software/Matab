USE [MatabDB]
GO
/****** Object:  StoredProcedure [dbo].[EditMonshi]    Script Date: 3/2/2020 1:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[EditMonshi]
@idmonshi int,
@namemonshi nvarchar(50),
@namek nvarchar(50),
@codem nvarchar(50),
@tel nvarchar(50),
@dateb nvarchar(50),
@datee nvarchar(50),
@salary int,
@datesalary nvarchar(50),
@tozih nvarchar(MAX)
AS
update Monshi set NameMonshi=@namemonshi,NameK=@namek,CodeM=@codem,Tel=@tel,DataB=@dateb,DateE=@datee,Salary=@salary,DateSalary=@datesalary,Tozih=@tozih where IDMonshi=@idmonshi
