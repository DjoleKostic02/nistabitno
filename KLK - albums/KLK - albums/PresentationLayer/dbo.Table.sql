CREATE TABLE [dbo].[Albums]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(200) NOT NULL, 
    [Artist] NVARCHAR(MAX) NULL, 
    [Price] DECIMAL(18, 2) NOT NULL
)
