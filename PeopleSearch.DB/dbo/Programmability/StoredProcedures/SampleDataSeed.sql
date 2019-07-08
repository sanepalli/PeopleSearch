CREATE PROCEDURE [dbo].[SampleDataSeed]
	
AS
	Insert into Person(FirstName, LastName, Age, Address, Interests, Picture)
	VALUES('John', 'Robert', 30, '123 Main Street USA', 'Sports, Music', '/Content/images/John.jpg'),
		('Emily', 'Haygen', 30, '123 Main Street USA', 'Movies, Singing', '/Content/images/Emily.jpg'),
		('Mike', 'Canopy', 30, '123 Main Street USA', 'Acting, Sports', '/Content/images/Mike.jpg'),
		('Smith', 'Robert', 30, '123 Main Street USA', 'Long Drives, Music', '/Content/images/smith.jpg'),
		('Stacy', 'Canopy', 30, '123 Main Street USA', 'Sports, Music', '/Content/images/Stacy.jpg');

RETURN 0
