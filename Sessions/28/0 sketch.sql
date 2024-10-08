/*
User
    Username varchar(50), unique
    FirstName varchar(50)
    LastName varchar(50)
    Unique first name, last name
CuisineType
    CuisineId int, primary key
    CuisineName varchar(50), unique
Ingredient
    IngredientId int, primary key
    IngredientName varchar(100), unique
    ImagePath varchar(255)
Recipe
    RecipeId int, primary key
    CuisineId (fk - CuisineType)
    RecipeName varchar(150), unique
    Calories int
    Status varchar(10) drafted, published, archived
    Drafted datetime
    Published datetime
    Archived datetime
    ImagePath varchar(255)
    CreatedBy (fk - User)
RecipeIngredient
    RecipeIngredientId int, primary key
    RecipeId (fk - Recipe)
    IngredientId (fk - Ingredient)
    MeasurementType varchar(50)
    Amount decimal (6, 2)
    Sequence int 
    Unique RecipeId, IngredientId, Sequence
RecipeDirection
    RecipeDirectionId int, primary key
    RecipeId (fk - Recipe)
    Directions text
    Sequence int
    Unique RecipeId, Sequence
Meal
    MealId int, primary key
    MealName varchar(100), unique
    Status bit
    ImagePath varchar(255) 
    Created datetime
    CreatedBy (fk - User)
CourseType
    CourseTypeId int, primary key
    CourseTypeName varchar(50), unique
MealCourse
    MealCourseId int, primary key
    MealId (fk - Meal)
    CourseTypeId (fk - CourseType)
    Sequence int
    Unique MealId, CourseTypeId, sequence (I cant figure out if I should include sequence here because not every meal has appetizer as the first course.
    Some may have main as the first course etc. On the other hand meal names and course names are unique. Can you clarify for me?)
CourseRecipe
    CourseRecipeId int, primary key
    MealCourseId (fk -> MealCourse)
    RecipeId (fk -> Recipe)
    IsMainDish bit
    Unique MealCourseId, RecipeId
Cookbook
    CookbookId int, primary key
    CookbookName varchar(100), unique
    Price decimal(10,2)
    Status bit
    ImagePath varchar(255)
    Created datetime
    CreatedBy (fk - User)
CookbookRecipe
    CookbookRecipeId int, primary key
    CookbookId (fk - Cookbook)
    RecipeId (fk - Recipe)
    Sequence int
    Unique CookbookId, RecipeId, Sequence
/*