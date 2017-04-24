CREATE TABLE Menu (
    ID int NOT NULL PRIMARY KEY,
	--Name of Menu
    Name varchar(50) NOT NULL
);

CREATE TABLE Recipe (
    ID int NOT NULL PRIMARY KEY,
	--Name of Recipe
    Name varchar(50) NOT NULL,
    --Intructions of recipe
    Intructions TEXT NOT NULL,
    --ID of Menu store recipe
    MenuID int
);

CREATE TABLE Recipe_Ingredient (
    ID int NOT NULL PRIMARY KEY,
	--id of recipe and ingredient that recipe have ingredient
    RecipeID int,
    IngredientID int,
    --quantity of ingredient
    Quantity varchar(50)
);

CREATE TABLE Ingredient (
    ID int NOT NULL PRIMARY KEY,
	--name of ingredient
    Name varchar(50) NOT NULL
);
