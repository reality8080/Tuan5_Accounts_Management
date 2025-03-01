CREATE DATABASE AccountManage
GO
USE AccountManage;
GO

CREATE TABLE Accounts(
	id BIGINT IDENTITY PRIMARY KEY,
	serie BIGINT UNIQUE,
	name NVARCHAR(100) not null,
	address NVARCHAR(100) not null,
	balance float
)
GO

CREATE PROCEDURE SelectAll
AS
BEGIN
	SELECT * FROM Accounts
END;
GO

CREATE PROCEDURE insertACC
	@serie BIGINT,
	@name NVARCHAR(100),
	@address NVARCHAR(100),
	@balance float
AS
BEGIN
	INSERT INTO Accounts(serie, name,address, balance)
	VALUES (@serie,@name, @address,@balance)
END;
GO

CREATE PROCEDURE upDateACC
	@serie BIGINT,
	@name NVARCHAR(100),
	@address NVARCHAR(100),
	@balance float
AS
BEGIN
	UPDATE Accounts
	SET name=@name,address=@address, balance=@balance
	WHERE serie=@serie;
END;
GO

CREATE PROCEDURE DeleteAcc
	@serie BIGINT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Accounts 
	WHERE serie=@serie;
END;
GO