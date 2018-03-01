CREATE TABLE [dbo].[Players]
(
	[PlayerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [JerseyNum] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL
)
