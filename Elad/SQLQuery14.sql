USE [Elad]
GO
/****** Object:  StoredProcedure [dbo].[GetStreetsByCityId]    Script Date: 07/12/2021 13:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
ALTER PROCEDURE [dbo].[GetStreetsByCityId] 
	
	@CityId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM [Street]
	WHERE [CityID] = @CityId
END
