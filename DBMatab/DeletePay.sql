USE [MatabDB]
GO
/****** Object:  StoredProcedure [dbo].[DeletePay]    Script Date: 3/6/2020 6:16:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[DeletePay]
@idpay int
AS
Delete from Pay where IDPay=@idpay
Go