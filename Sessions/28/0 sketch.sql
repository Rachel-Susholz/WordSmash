/*
--AS You didn't put in any nulls or not blank constraints. You don't have to, just make sure you put it in the actual tables. From experience I would recommend that you do put it in here.

User
    UserId int, primary key 
    Username varchar(50), unique
    FirstName varchar(50)
    LastName varchar(50)

CuisineType
    CuisineId int, primary key
    CuisineName varchar(50), unique

Ingredient
    IngredientId int, primary key
    IngredientName varchar(100), unique
--AS ImagePath will be computed and doesn't need a type.
    ImagePath

Recipe
    RecipeId int, primary key
    CuisineId (fk - CuisineType)
    RecipeName varchar(150), unique
    --AS Should be more then 0
    Calories int
    --AS Status should be computed of the dates columns
    Status as case (
        when archived is not null then archived
        when published is not null and archived is null then published
        else drafted
        end )
    --AS Drafted cannot be null. Also a good idea to default to getdate(), and to check that it is not a past date.
    Drafted datetime default getdate not null 
    Published datetime
    Archived datetime
    --AS You need to add constraints to ensure that the dates make sense. What comes first, and ensure nothing is a future date.
    ImagePath 
    UserId (fk - User)

Measurement
    MeasurementId int primary key 
    MeasurementType varchar(50)

RecipeIngredient
    RecipeIngredientId int, primary key
    RecipeId (fk - Recipe)
    IngredientId (fk - Ingredient)
    MeasurementId (fk - Measurement)
    --AS The measurement type is going to be retyping the same values many times. Better make a master list (table) and put the foreign key here. 
    Amount decimal (6, 2)
    Sequence int 
    --AS This constraint will allow one recipe to have 2 ingredients by the 1 sequence as long as the ingredientid is diffrent. That shouldn't be allowed
    Unique RecipeId, Sequence

RecipeDirection
--AS Missing null constraints.
    RecipeDirectionId int, primary key
    RecipeId (fk - Recipe)
    Directions text
    Sequence int
    Unique RecipeId, Sequence

Meal
    MealId int, primary key
    MealName varchar(100), unique
    Status bit
    --AS As before, the image path should always be computed. Created can default to getdate() and CreatedBy should be name UserId
    ImagePath 
    Created datetime default getdate
    UserId (fk - User)

CourseType
    CourseTypeId int, primary key
    CourseTypeName varchar(50), unique
    Sequence int 
    --AS This is a bit confusing for many students, but the course also needs a seq. A example of courses would be 
    -- "hors d'oeuvre, soup, appetizer, salad, fish, main course, palate cleanser, second main course, dessert, and mignardise"
    -- Hors d'oeuvre will always be 1, soup 2 and so on. We don't need Hors d'oeuvre in every meal, but when it is, it will be first.

MealCourse
    MealCourseId int, primary key
    MealId (fk - Meal)
    CourseTypeId (fk - CourseType)
    Unique MealId, CourseTypeId  
    --AS It is a bit confusing, basically we only need a sequence in the coursetype table not here. I explained a little there, and I will slack you a voice note. 
    (I cant figure out if I should include sequence here because not every meal has appetizer as the first course.
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
    --AS Same as before with computed and UserId
    ImagePath
    Created datetime
    UserID (fk - User)

CookbookRecipe
    CookbookRecipeId int, primary key
    CookbookId (fk - Cookbook)
    RecipeId (fk - Recipe)
    Sequence int
    --AS Same as previous comment, this will not block from entering the same recipe twice, and will also not block from entering the same sequence twice.
    Unique CookbookId, RecipeId
    Unique CookbookId, Sequence
/*