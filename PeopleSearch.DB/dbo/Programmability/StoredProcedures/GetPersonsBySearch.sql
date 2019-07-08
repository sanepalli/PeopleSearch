CREATE PROCEDURE [dbo].[GetPersonsBySearch]
	@searchString VARCHAR(50) = null
AS

BEGIN
		
	Select 
		PersonId,
		FirstName,
		LastName,
		[Address],
		Age,
		Interests,
		Picture
	From Person
	WHERE (FirstName LIKE '%' + @searchString + '%' OR LastName LIKE '%' + @searchString + '%') OR ISNULL(@searchString,'') =''
	
END