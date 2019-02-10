CREATE DATABASE MealTracker

Use MealTracker;

DROP TABLE IF EXISTS Ingredients, Meals, Users;

CREATE TABLE Users 
	(userID INT identity NOT NULL PRIMARY KEY,
	 username varchar NOT NULL,
	 passhash varchar NOT NULL,
	 email varchar)

CREATE TABLE Meals
	(mealID INT identity NOT NULL PRIMARY KEY,
	 userID INT NOT NULL FOREIGN KEY REFERENCES Users(userID),
	 mealname varchar NOT NULL,
	 totalcost smallmoney NOT NULL,
	 servings tinyint)

CREATE TABLE Ingredients
	(ingredID INT identity NOT NULL PRIMARY KEY,
	 mealID INT NOT NULL FOREIGN KEY REFERENCES Meals(mealID),
	 ingredname varchar NOT NULL,
	 cost smallmoney NOT NULL);


SELECT * FROM Users;
