CREATE TABLE [dbo].[Players]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[NickName] NVARCHAR(50) NULL,
	[DateOfBirth] DateTime NULL,
	[JerseyNumber] INT NULL
)
