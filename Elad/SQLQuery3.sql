
-- =============================================
CREATE PROCEDURE GetStreetsByCityId 
	
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
GO
