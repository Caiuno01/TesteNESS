USE [MASTER]
GO

CREATE DATABASE [TESTENESS]
GO

ALTER DATABASE TESTENESS MODIFY FILE 
( NAME = N'TESTENESS' , SIZE = 10MB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
GO
ALTER DATABASE TESTENESS MODIFY FILE 
( NAME = N'TESTENESS_log' , SIZE = 10MB , MAXSIZE = 100MB , FILEGROWTH = 10%)
GO

USE [TESTENESS]
GO

CREATE TABLE USUARIOS(
	IdUsuario INT IDENTITY NOT NULL,
	Nome NVARCHAR(50),
	Cpf NVARCHAR(14),
	Telefone NVARCHAR(20)
	PRIMARY KEY(IdUsuario)
)
GO

INSERT INTO USUARIOS VALUES('Cristiane Larissa Almada', '918.799.355-46', '(85) 99211-0142')
INSERT INTO USUARIOS VALUES('Bruna Elza T�nia Brito', '845.996.415-96', '(91) 2549-0698')
INSERT INTO USUARIOS VALUES('Diogo Augusto Elias Peixoto', '876.217.667-60', '(79) 99239-4020')
GO
