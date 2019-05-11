CREATE DATABASE MealTracker

Use MealTracker;

DROP TABLE IF EXISTS Ingredients, Meals, Users;

CREATE TABLE Users 
	(userID INT identity NOT NULL PRIMARY KEY,
	 username varchar(20) NOT NULL,
	 passhash varchar NOT NULL,
	 email varchar(50))

CREATE TABLE Meals
	(mealID INT identity NOT NULL PRIMARY KEY,
	 userID INT NOT NULL,
	 mealname varchar(50) NOT NULL,
	 totalcost smallmoney NOT NULL,
	 servings int)

CREATE TABLE Ingredients
	(ingredID INT identity NOT NULL PRIMARY KEY,
	 mealID INT NOT NULL,
	 ingredname varchar(50) NOT NULL,
	 cost smallmoney NOT NULL);


INSERT INTO Meals (userID,mealname,totalcost,servings) 
VALUES(1,'Meat Pie', $8, 4),
(1,'Apple Sauce', $2, 2),
(1,'Spaghetti', $4, 3),
(1,'Chicken Tortilini', $12, 4);

SELECT * FROM Users;

SELECT * FROM Meals;
