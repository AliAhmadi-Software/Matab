USE [MatabDB]
GO
/****** Object:  StoredProcedure [dbo].[SearchForLogin]    Script Date: 3/1/2020 1:12:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SearchForLogin]
@username nvarchar(100),
@pasword nvarchar(50),
@acess nvarchar(50)
AS
select * from Karbar where UserName=@username AND Pasword=@pasword AND Acess=@acess
