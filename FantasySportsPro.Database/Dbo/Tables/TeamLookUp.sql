CREATE TABLE [dbo].[TeamLookUp]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[City] NVARCHAR(50) NOT NULL,
	[State] NVARCHAR(50) NULL,
	[Country] NVARCHAR(50) NOT NULL,
	[SportAssociationId] INT NOT NULL CONSTRAINT [FK_SportAssociationLookUp_TeamLookup] FOREIGN KEY REFERENCES SportAssociationLookUp(Id)
)
