CREATE TABLE [dbo].[Person]
(
	[PersonId] INT  IDENTITY (1, 1) NOT NULL,
	[FirstName]              VARCHAR (255)   NULL,
	[LastName]		VARCHAR (255) NULL,
    [Age]              INT   NULL, 
    [Address] VARCHAR(1000) NULL, 
    [Picture] VARCHAR(MAX) NULL, 
    [Interests] VARCHAR(MAX) NULL,
	CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonId] ASC)
)
