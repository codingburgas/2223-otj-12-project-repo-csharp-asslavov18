CREATE DATABASE dbNutriApp;
USE dbNutriApp;

CREATE TABLE Users (
    username VARCHAR(50) PRIMARY KEY,
    password VARCHAR(50) NOT NULL
);

INSERT INTO Users (username, password)
VALUES ('admin', 'admin1234'),
       ('anton1', 'pass12'),
       ('valentin12', 'parolka1');