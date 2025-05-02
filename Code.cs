CREATE DATABASE LP5;

use LP5

CREATE TABLE Benutzer (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(100) NOT NULL,
    email NVARCHAR(255) NULL
);

CREATE TABLE Aufgabe (
    id INT PRIMARY KEY IDENTITY(1,1),
    titel NVARCHAR(200) NOT NULL,
    beschreibung NVARCHAR(MAX) NULL,
    faellig_am DATE NULL,
    prioritaet NVARCHAR(50) NULL,
    status NVARCHAR(50) NOT NULL,
    benutzer_id INT NOT NULL,
    CONSTRAINT FK_Aufgabe_Benutzer FOREIGN KEY (benutzer_id) REFERENCES Benutzer(id)
);
