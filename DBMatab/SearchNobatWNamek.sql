USE [MatabDB]
GO
/****** Object:  StoredProcedure [dbo].[SearchNobatWNamek]    Script Date: 3/29/2020 6:26:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SearchNobatWNamek]
@namek nvarchar(50)
AS
Select * from Nobat where NameK like '%' + @namek + '%'
go
