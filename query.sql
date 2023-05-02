CREATE DATABASE dbNutriApp;
GO

USE dbNutriApp;
GO

CREATE TABLE Exercises (
    ExerciseID int PRIMARY KEY,
    Name nvarchar(50),
    Muscles nvarchar(50),
    HardLevel nvarchar(50),
    CalPerMin int
);

CREATE TABLE FoodItems (
    FoodID int PRIMARY KEY,
    Name nvarchar(50),
    Fat int,
    Carbs int,
    Protein int,
    Calories int,
    Weight int
);

CREATE TABLE Users (
    username nvarchar(50) PRIMARY KEY,
    password nvarchar(50)
);

CREATE TABLE UserExcercises (
    username nvarchar(50),
    date date,
    ExerciseID int,
    Repetitions int,
    CalBurned int,
    PRIMARY KEY (username, date, ExerciseID),
    FOREIGN KEY (username) REFERENCES Users(username),
    FOREIGN KEY (ExerciseID) REFERENCES Exercises(ExerciseID)
);

CREATE TABLE UserFood (
    username nvarchar(50),
    date date,
    FoodID int,
    Servings int,
    CalGained int,
    PRIMARY KEY (username, date, FoodID),
    FOREIGN KEY (username) REFERENCES Users(username),
    FOREIGN KEY (FoodID) REFERENCES FoodItems(FoodID)
);
