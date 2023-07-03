CREATE DATABASE MythSportsDb;

GO
USE [MythSportsDb]
GO
CREATE TABLE [dbo].[SportsEvent](
	[Id] [varchar](20) NOT NULL PRIMARY KEY,
	[JsonData] [nvarchar](max) NULL,
)