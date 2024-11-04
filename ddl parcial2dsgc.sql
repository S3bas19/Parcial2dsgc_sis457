CREATE DATABASE Parcial2dsgc;

USE [master]
GO
CREATE LOGIN [usrparcial2] WITH PASSWORD='12345678',
  DEFAULT_DATABASE = [Parcial2dsgc],
  CHECK_EXPIRATION = OFF,
  CHECK_POLICY = ON
GO
USE [Parcial2dsgc]
GO
CREATE USER [usrparcial2] FOR LOGIN [usrparcial2]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrparcial2]
GO

CREATE TABLE Serie (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  titulo VARCHAR(250) NOT NULL,
  sinopsis VARCHAR(5000) NOT NULL,
  director VARCHAR(100) NOT NULL,
  episodios INT NOT NULL,
  fechaEstreno DATE NOT NULL,
  estado SMALLINT NOT NULL
);

INSERT INTO Serie(titulo, sinopsis, director, episodios, fechaEstreno, estado)
VALUES('Rec', 'una llamada de auxilio se vuelve una pesadilla', 'Agustin', 24, '2018-02-12', 2);

CREATE PROC paSerieListar @parametro VARCHAR(50)
AS
  SELECT * FROM Serie
  WHERE estado<>-1 AND sinopsis LIKE '%'+REPLACE(@parametro,' ','%')+'%';
