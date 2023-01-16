USE [ApSampleDb]
GO

/****** Object:  StoredProcedure [dbo].[SpInsertAppUserAddressArchive]    Script Date: 1/16/2023 11:09:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[SpInsertAppUserAddressArchive]
@Id bigint,
@Address nvarchar(255),
@CityId int,
@AppUserId int
AS

INSERT INTO [acc].[AppUserAddressArchive]
           ([Id]
           ,[Address]
           ,[CityId]
           ,[AppUserId])
     VALUES
           (@Id, 
            @Address,
            @CityId, 
            @AppUserId)
GO


