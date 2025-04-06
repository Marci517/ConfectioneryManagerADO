/*
Bencze Marton
bmim2214
521
sajat2
Új adatbázisban legyenek a táblák létrehozva.
Az elsődleges kulcsok és hivatkozási épség megszorítások helyesen legyenek beállítva.
Az elsődleges kulcsok típusa INT legyen és - ha egyszerűek - automatikusan sorszámozhatónak tegyétek őket.
Az adatbázis legyen 3. normál formában. (<=> Legyen helyes az E/K diagram és a relációs AB tábláivá való átalakítás.)
Ne feledkezzünk meg arról, hogy kell legyen az adatbázisban számlázási lehetőség
(pl. Foglalasok, FoglalasTartalma vagy Szamlak, SzamlakTartalma, vagy ehhez hasonló táblák)
*/

//CREATE DATABASE bmim2214_sajat2
USE bmim2214_sajat2

CREATE TABLE Helyszinek(
	HID INT IDENTITY(1,1)
	CONSTRAINT PK_Helyszinek_HID PRIMARY KEY (HID),
	Megye VARCHAR(50)
	CONSTRAINT U_Helyszinek_Megye UNIQUE (Megye)
)

CREATE TABLE Cukraszdak(
	Nev VARCHAR(50)
	CONSTRAINT U_Cukraszdak_Nev UNIQUE (Nev),
	Dolgozok_szama INT,
	CID INT IDENTITY(1,1)
	CONSTRAINT PK_Cukraszdak_CID PRIMARY KEY (CID),
	HID INT,
	CONSTRAINT FK_Cukraszdak_CID_Helyszinek_HID FOREIGN KEY (HID) REFERENCES Helyszinek(HID)
	
	
	)

CREATE TABLE Dolgozok(
	DID INT IDENTITY(1,1)
	CONSTRAINT PK_Dolgozok_DID PRIMARY KEY (DID),
	CID INT
	CONSTRAINT FK_Dolgozok_CID_Cukraszdak_CID FOREIGN KEY (CID) REFERENCES Cukraszdak(CID),
	CNP INT
	CONSTRAINT CNP UNIQUE (CNP),
	Nev VARCHAR(100),
	Pozicio VARCHAR(100)
	)

CREATE TABLE Termekek(
	TID INT IDENTITY(1,1)
	CONSTRAINT PK_Termekek_TID PRIMARY KEY(TID),
	Nev VARCHAR(50)
	)

CREATE TABLE Vasarlok(
	VID INT IDENTITY(1,1)
	CONSTRAINT PK_Vasarlok_VID PRIMARY KEY(VID),
	Nev VARCHAR(100)
	CONSTRAINT U_Vasarlok_Nev UNIQUE (Nev)
	)

CREATE TABLE Vasarlasok(
	VSID INT IDENTITY(1,1)
	CONSTRAINT PK_Vasarlasok_VSID PRIMARY KEY(VSID),
	Ido DATETIME,
	Osszeg MONEY,
	VID INT
	CONSTRAINT FK_Vasarlasok_VID FOREIGN KEY (VID) REFERENCES Vasarlok(VID),
	CID INT
	CONSTRAINT FK_Vasarlasok_CID FOREIGN KEY (CID) REFERENCES Cukraszdak(CID)
	)

CREATE TABLE VasaroltTermekek(
	TID INT,
	VSID INT
	CONSTRAINT PK_VasaroltTermekek_VSID_TID PRIMARY KEY (TID, VSID),
	CONSTRAINT FK_VasaroltTermekek_VSID FOREIGN KEY (VSID) REFERENCES Vasarlasok(VSID),
	CONSTRAINT FK_VasaroltTermekek_TID FOREIGN KEY (TID) REFERENCES Termekek(TID),
	Mennyiseg INT,
	ReszOsszeg MONEY

	)

CREATE TABLE TaroltTermekek(
	TID INT,
	CID INT
	CONSTRAINT PK_TaroltTermekek_CID_TID PRIMARY KEY (TID, CID),
	CONSTRAINT FK_TaroltTermekek_CID FOREIGN KEY (CID) REFERENCES Cukraszdak(CID),
	CONSTRAINT FK_TaroltTermekek_TID FOREIGN KEY (TID) REFERENCES Termekek(TID),
	Raktaron INT,
	Ar MONEY
	)

CREATE TABLE Kosarak(
	KID INT IDENTITY(1, 1)
	CONSTRAINT PK_Kosarak_KID PRIMARY KEY(KID),
	VID INT
	CONSTRAINT FK_Kosarak_VID FOREIGN KEY (VID) REFERENCES Vasarlok(VID)
)

CREATE TABLE KosarTartalma(
	KID INT,
	TID INT
	CONSTRAINT PK_KosarTartalma_Kosarak_KID_TID PRIMARY KEY (KID, TID),
	CONSTRAINT FK_KosarTartalma_Termekek FOREIGN KEY (TID) REFERENCES Termekek (TID),
	CONSTRAINT FK_KosarTartalma_Kosarak FOREIGN KEY (KID) REFERENCES Kosarak (KID),
	Menny INT
)


GO

INSERT INTO Helyszinek VALUES
						('Pecs'),
						('Hargita'),
						('Pest'),
						('Cluj'),
						('Maros'),
						('Kovaszna'),
						('Galac')	

INSERT INTO Cukraszdak VALUES
						('Marcipan', 5, 1),
						('NemTudom', 15, 1),
						('Nemmm', 30, 5),
						('Napos', 30, 3),
						('Contact', 25, 3),
						('Living', 12, 7),
						('Plani', 3, 2),
						('Bulga', 9, 4)



INSERT INTO Termekek VALUES
						('Madartej'),
						('Fagyi'),
						('Kave'),
						('Repatorta')


INSERT INTO Vasarlok VALUES
						('Marci'),
						('Kati'),
						('Bela'),
						('Jozsi')

INSERT INTO TaroltTermekek VALUES
							(1, 1, 10, 20),  -- TermekId, CukraszdaID, Raktaron, Ar
							(1, 2, 17, 30),
							(1, 3, 0, 40),
							(1, 4, 16, 8),
							(1, 5, 2, 10),
							(2, 6, 17, 31),
							(2, 7, 0, 41),
							(2, 8, 16, 9),
							(2, 5, 2, 11),
							(3, 2, 17, 32),
							(3, 3, 0, 42),
							(3, 4, 16, 10),
							(3, 5, 2, 12),
							(3, 1, 2, 2),
							(3, 6, 10, 18),
							(4, 1, 5, 30),
							(4, 2, 5, 30),
							(4, 3, 5, 30),
							(4, 4, 5, 30),
							(4, 5, 5, 30),
							(4, 6, 5, 30),
							(4, 7, 5, 30),
							(4, 8, 5, 30)

INSERT INTO Kosarak VALUES
					(1),
					(2),
					(3),
					(4)


INSERT INTO KosarTartalma VALUES
							(1, 1, 2),
							(1, 3, 2),
							(1, 2, 2),
							(1, 4, 2),
							(2, 1, 10),
							(2, 3, 10),
							(2, 2, 10),
							(2, 4, 15),
							(3, 1, 1),
							(3, 4, 1)
GO
CREATE TRIGGER trg_Cukraszdak_Delete
ON Cukraszdak
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON

    DELETE FROM VasaroltTermekek
    WHERE VSID IN (SELECT VSID FROM Vasarlasok WHERE CID IN (SELECT CID FROM DELETED))

    DELETE FROM Vasarlasok
    WHERE CID IN (SELECT CID FROM DELETED)

    DELETE FROM TaroltTermekek
    WHERE CID IN (SELECT CID FROM DELETED)

    DELETE FROM Dolgozok
    WHERE CID IN (SELECT CID FROM DELETED)

    DELETE FROM Cukraszdak
    WHERE CID IN (SELECT CID FROM DELETED)
END
GO