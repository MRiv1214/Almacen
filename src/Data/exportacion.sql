PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE usuarios (
    id INTEGER PRIMARY KEY,
    nombre TEXT,
    email TEXT UNIQUE,
    edad INTEGER
);
INSERT INTO usuarios VALUES(1,'Usuario1','usuario1@example.com',25);
INSERT INTO usuarios VALUES(2,'Usuario2','usuario2@example.com',30);
COMMIT;
