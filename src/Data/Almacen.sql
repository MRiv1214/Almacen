PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE users(
userId INTEGER PRIMARY KEY,
password BLOB,
name TEXT,
lastName TEXT
);
INSERT INTO users VALUES(1,'hashed_password_1','John','Doe');
INSERT INTO users VALUES(2,'hashed_password_2','Alice','Smith');
INSERT INTO users VALUES(3,'hashed_password_3','Bob','Johnson');
CREATE TABLE employees(
employeeId TEXT PRIMARY KEY,
careerId TEXT,
userId INTEGER,
userType INTEGER
);
CREATE TABLE students (studentId INTEGER PRIMARY KEY, userId INTEGER REFERENCES users (userId), carreerId TEXT);
COMMIT;
