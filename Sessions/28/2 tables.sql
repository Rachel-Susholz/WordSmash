--AS Great job, 91% See comments.
drop table if exists cookbookrecipe
drop table if exists cookbook
drop table if exists courserecipe
drop table if exists mealcourse
drop table if exists meal
drop table if exists coursetype
drop table if exists recipedirection
drop table if exists recipeingredient
drop table if exists measurement
drop table if exists recipe
drop table if exists ingredient
drop table if exists cuisinetype
drop table if exists staffmember
go

--AS -2 Unique constraints should be named even on a column level. You didn't name any of them.

-- User Table
create table dbo.StaffMember(
    StaffMemberId int not null identity primary key,
    UserName varchar(50) unique not null
        constraint ck_UserName_cannot_be_blank check (UserName <> ''),
    FirstName varchar(50) not null
        constraint ck_FirstName_cannot_be_blank check (FirstName <> ''),
    LastName varchar(50) not null
        constraint ck_LastName_cannot_be_blank check (LastName <> '')
)

-- CuisineType Table
create table dbo.CuisineType(
    CuisineId int not null identity primary key,
    CuisineName varchar(50) unique not null
        constraint ck_CuisineName_cannot_be_blank check (CuisineName <> '')
)

-- Ingredient Table
create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(100) unique not null
        constraint ck_IngredientName_cannot_be_blank check (IngredientName <> ''),
    --AS -1 If I have a ingredient that has a space in the name, i.e. baking soda, the format for the image path would be incorrect.
    ImagePath as ('Ingredient_' + IngredientName + '.jpg') 
)

-- Recipe Table
create table dbo.Recipe(
    RecipeId int not null identity primary key,
    CuisineId int not null 
        constraint f_Cuisine_Recipe foreign key references CuisineType(CuisineId),
    RecipeName varchar(150) unique not null
        constraint ck_RecipeName_cannot_be_blank check (RecipeName <> ''),
    --AS -1 Calories cannot be null
    Calories int 
        constraint ck_calorie_count_must_be_greater_than_zero check (calories > 0),
    --AS -1 Same issue as by the ingredients, if the recipe name has a space it would not be in the correct format
    ImagePath as ('Recipe_' + RecipeName + '.jpg'),
    RecipeStatus as (
        case 
            when archived is not null then 'archived'
            when published is not null and archived is null then 'published'
            else 'drafted'
        end
    ),
    Drafted datetime default getdate() not null 
        constraint ck_must_be_drafted_on_past_or_present_date check (drafted <= getdate()),
    Published datetime
        constraint ck__must_be_published_on_past_or_present_date check (published <= getdate()),
    Archived datetime 
        constraint ck__must_be_archived_on_past_or_present_date check (archived <= getdate()),
    StaffMemberId int not null 
        constraint f_StaffMember_Recipe foreign key references StaffMember(StaffMemberId),
        constraint ck_drafted_must_be_before_published check (drafted < published),
        constraint ck_published_must_be_before_archived check (published < archived)

)

-- Measurement Table
create table dbo.Measurement(
    MeasurementId int not null identity primary key,
    MeasurementType varchar(50) unique not null
        constraint ck_MeasurementType_cannot_be_blank check (MeasurementType <> '')
)

-- RecipeIngredient Table
create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null 
        constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    IngredientId int not null 
        constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    MeasurementId int not null 
        constraint f_Measurement_RecipeIngredient foreign key references Measurement(MeasurementId),
    Amount decimal(6, 2) not null
        constraint ck_Amount_must_be_greater_than_zero check (Amount > 0),
    IngredientSequence int not null
        constraint ck_IngredientSequence_must_be_greater_than_zero check (IngredientSequence > 0),
        constraint u_RecipeIngredient_Recipe_IngredientSequence unique (RecipeId, IngredientSequence),
        constraint u_RecipeIngredient_Recipe_Ingredient unique (RecipeId, IngredientId)
)

-- RecipeDirection Table
create table dbo.RecipeDirection(
    RecipeDirectionId int not null identity primary key,
    RecipeId int not null 
        constraint f_Recipe_RecipeDirection foreign key references Recipe(RecipeId),
    --AS -1 You need to check to make sure that directions is not blank.
    --AS text datatype can cause you issues later in the course. Better to stick with varchar
    Directions text not null,
    DirectionSequence int not null
        constraint ck_DirectionSequence_must_be_greater_than_zero check (DirectionSequence > 0),
        constraint u_RecipeDirection_Recipe_DirectionSequence unique (RecipeId, DirectionSequence)
)

-- Meal Table
create table dbo.Meal(
    MealId int not null identity primary key,
    MealName varchar(100) unique not null
         constraint ck_MealName_cannot_be_blank check (MealName <> ''),
    --AS -1 Same issue as previous image paths
    ImagePath as ('Meal_' + MealName + '.jpg'),
    MealStatus bit not null,
    Created datetime default getdate() not null
        constraint ck_Meal_must_be_created_on_past_or_present_date check (Created <= getdate()),
    StaffMemberId int not null 
        constraint f_StaffMember_Meal foreign key references StaffMember(StaffMemberId)
)

-- CourseType Table
create table dbo.CourseType(
    CourseTypeId int not null identity primary key,
    --AS -2 Both the Course Name and sequence should be unique. You don't need dessert entered twice, and you don't want apertif and dessert to be the same seq.
    CourseTypeName varchar(50) not null
        constraint ck_CourseTypeName_cannot_be_blank check (CourseTypeName <> ''),
    CourseSequence int not null 
        constraint ck_CourseSequence_must_be_greater_than_zero check (CourseSequence > 0)
)

-- MealCourse Table
create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null 
        constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseTypeId int not null 
        constraint f_CourseType_MealCourse foreign key references CourseType(CourseTypeId),
        constraint u_MealCourse_Meal_CourseType unique (MealId, CourseTypeId)
)

-- CourseRecipe Table
create table dbo.CourseRecipe(
    CourseRecipeId int not null identity primary key,
    MealCourseId int not null 
        constraint f_MealCourse_CourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null 
        constraint f_Recipe_CourseRecipe foreign key references Recipe(RecipeId),
    IsMainDish bit not null,
        constraint u_CourseRecipe_MealCourse_CourseRecipe unique (MealCourseId, RecipeId)
)

-- Cookbook Table
create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    CookbookName varchar(100) unique not null
        constraint ck_CookbookName_cannot_be_blank check (CookbookName <> ''),
    Price decimal(10, 2) not null
        constraint ck_Price_must_be_greater_than_zero check (Price > 0),
    --AS Image path has same issue as previous images
    ImagePath as ('Cookbook_' + CookbookName + '.jpg'),
    CookbookStatus bit not null,
    Created datetime default getdate() not null
        constraint ck_Cookbook_must_be_created_on_past_or_present_date check (Created <= getdate()),
    StaffMemberId int not null 
        constraint f_StaffMember_Cookbook foreign key references StaffMember(StaffMemberId)
)

-- CookbookRecipe Table
create table dbo.CookbookRecipe(
    CookBookRecipeId int not null identity primary key,
    CookbookId int not null references Cookbook(CookbookId),
    RecipeId int not null references Recipe(RecipeId),
    RecipeSequence int not null
        constraint ck_RecipeSequence_must_be_greater_than_zero check (RecipeSequence > 0),
        constraint u_CookbookRecipe_cookbook_recipe unique (CookbookId, RecipeId),
        constraint u_CookbookRecipe_cookbook_RecipeSequence unique (CookbookId, RecipeSequence)
);