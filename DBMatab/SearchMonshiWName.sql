USE [MatabDB]
GO
/****** Object:  StoredProcedure [dbo].[SearchMonshiWName]    Script Date: 3/2/2020 5:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SearchMonshiWName]
@name nvarchar(50)
AS
Select * from Monshi where NameK=@name
