--Bencze Marton
--bmim2214
--521
--lab5-logins

USE bmim2214_sajat2

CREATE LOGIN Fonok WITH PASSWORD = 'fonok'
CREATE USER Fonok FOR LOGIN Fonok
GRANT SELECT, DELETE, UPDATE ON DATABASE::bmim2214_sajat2 TO Fonok

CREATE LOGIN Vendeg WITH PASSWORD = 'vendeg'
CREATE USER Vendeg FOR LOGIN Vendeg
GRANT SELECT ON DATABASE::bmim2214_sajat2 TO Vendeg

CREATE LOGIN Felhasznalo WITH PASSWORD = 'felhasznalo'
CREATE USER Felhasznalo FOR LOGIN Felhasznalo
GRANT SELECT, UPDATE ON DATABASE::bmim2214_sajat2 TO Felhasznalo

GO
CREATE PROCEDURE Registration (@Username NVARCHAR(50), @Password NVARCHAR(50))
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'CREATE LOGIN ' + QUOTENAME(@Username) + ' WITH PASSWORD = ' + QUOTENAME(@Password, '''')
    EXEC sp_executesql @SQL

    SET @SQL = 'CREATE USER ' + QUOTENAME(@Username) + ' FOR LOGIN ' + QUOTENAME(@Username)
    EXEC sp_executesql @SQL

    SET @SQL = 'GRANT SELECT, UPDATE ON DATABASE::bmim2214_sajat2 TO ' + QUOTENAME(@Username)
    EXEC sp_executesql @SQL
END
GO


--EXEC Registration 'Fp', 'fp'

