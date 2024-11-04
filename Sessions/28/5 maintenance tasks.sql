--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

delete cbr
from CookbookRecipe cbr
join Cookbook c 
on cbr.CookbookId = c.CookbookId
join StaffMember sm 
on c.StaffMemberId = sm.StaffMemberId
where sm.FirstName = 'John' and sm.LastName = 'Doe'

delete c
from Cookbook c
join StaffMember sm
on c.StaffMemberId = sm.StaffMemberId
where sm.FirstName = 'John' and sm.LastName = 'Doe'

delete cr
--select *
from MealCourse mc
join CourseRecipe cr
on cr.MealCourseId = mc.MealCourseId
join Meal m
on mc.MealId = m.MealId
join StaffMember sm
on m.StaffMemberId = sm.StaffMemberId
where sm.FirstName = 'John' and sm.LastName = 'Doe'

delete mc
--select *
from MealCourse mc
join Meal m 
on mc.MealId = m.MealId
join StaffMember sm 
on m.StaffMemberId = sm.StaffMemberId
where sm.FirstName = 'John' and sm.LastName = 'Doe'

delete m
from Meal m
join StaffMember sm
on m.StaffMemberId = sm.StaffMemberId
where sm.FirstName = 'John' and sm.LastName = 'Doe'

delete ri 
from RecipeIngredient ri 
join Recipe r 
on ri.RecipeId = r.RecipeId
join StaffMember sm 
on r.StaffMemberId = sm.StaffMemberId
where sm.FirstName = 'John' and sm.LastName = 'Doe'

delete rd 
from RecipeDirection rd 
join Recipe r 
on rd.RecipeId = r.RecipeId 
join StaffMember sm 
on r.StaffMemberId = sm.StaffMemberId 
where sm.FirstName = 'John' and sm.LastName = 'Doe'

delete r
from Recipe r
join StaffMember sm
on r.StaffMemberId = sm.StaffMemberId
where sm.FirstName = 'John' and sm.LastName = 'Doe'

delete sm
from StaffMember sm
where sm.FirstName = 'John' and sm.LastName = 'Doe'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
;
with x as (
    select 
        CuisineId, 
        ClonedRecipeName = RecipeName + ' - clone', 
        Calories, 
        Drafted = getdate(),
        Published = null,
        Archived = null,
        StaffMemberId
    from Recipe
    where RecipeName = 'Chocolate Chip Cookies'
)
 
insert into Recipe (CuisineId, RecipeName, Calories, Drafted, Published, Archived, StaffMemberId)
select CuisineId, ClonedRecipeName, Calories, Drafted, Published, Archived, StaffMemberId
from x

insert into RecipeIngredient (RecipeId, IngredientId, Amount, MeasurementId, IngredientSequence)
select RecipeId = (select RecipeId from recipe where RecipeName = 'Chocolate Chip Cookies - clone'), 
    ri.IngredientId, 
    ri.Amount, 
    ri.MeasurementId,
	ri.IngredientSequence
from Recipe r  
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'

insert into RecipeDirection (RecipeId, DirectionSequence, Directions)
select 
    RecipeId = (select RecipeId from Recipe where RecipeName = 'Chocolate Chip Cookies - clone'),  
    rd.DirectionSequence, 
    rd.Directions
from RecipeDirection rd
join Recipe r 
on rd.RecipeId = r.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
-- Step 1: Insert the new cookbook for the specified user
;
with x as (
    select
		sm.StaffMemberId, 
        CookbookName = 'Recipes by ' + FirstName + ' ' + LastName,
        Price = count(r.RecipeId) * 1.33
    from StaffMember sm
    left join Recipe r 
	on sm.StaffMemberId = r.StaffMemberId
    where sm.FirstName = 'John' 
	and sm.LastName = 'Doe' 
    group by sm.StaffMemberId, sm.FirstName, sm.LastName
)

insert into Cookbook (CookbookName, Price, CookbookStatus, Created, StaffMemberId)
select 
    CookbookName, 
    Price, 
    1, 
    getdate(), 
    StaffMemberId
from x


;
with x as (
    select CookbookId
    from Cookbook
    where CookbookName = 'Recipes by John Doe'
)
insert into CookbookRecipe (CookbookId, RecipeId, RecipeSequence)
select 
    (select CookbookId from x), 
    r.RecipeId, 
    RecipeSequence = row_number() over (order by r.RecipeName)
from Recipe r
join StaffMember sm 
on r.StaffMemberId = sm.StaffMemberId
where sm.FirstName = 'John' and sm.LastName = 'Doe' 


/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/

update r
set Calories = r.Calories + (
    select
    (
		case
            when m.MeasurementType = 'ounce' then ri.Amount * -2
            when m.MeasurementType = 'stick' then ri.Amount * -10
            else 0 
        end
	)
    from RecipeIngredient ri
	join Measurement m
	on ri.MeasurementId = m.MeasurementId
	where ri.IngredientId = (
          select IngredientId
          from Ingredient
          where IngredientName = 'Butter'  
      )
	and r.RecipeId = ri.RecipeId
)
from recipe r
where RecipeId in ( select ri.RecipeId
	from RecipeIngredient ri
    where ri.IngredientId = (
    select IngredientId
    from Ingredient
    where IngredientName = 'Butter'
    ))

--RS can you explain to me why when I run the subquery alone from recipe, all 7 recipes are updated? why do I need the outer where clause to specify that the update 
--should only affect those recipes with butter?
/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
with x as (
    select AvgHoursToPublish = avg(datediff(hour, drafted, published))
    from recipe
    where published is not null
),

y as (
    select r.RecipeId, r.RecipeName, r.Drafted, sm.FirstName, sm.LastName
    from recipe r
    join StaffMember sm 
	on r.StaffMemberId = sm.StaffMemberId
    where r.Published is null
),

z as (
    select 
        y.FirstName,
        y.LastName,
        y.RecipeName,
        DraftHours = datediff(hour, y.Drafted, getdate()),
        AvgHours = x.AvgHoursToPublish
    from y, x
    where datediff(hour, y.drafted, getdate()) > x.AvgHoursToPublish
)

select 
    UserFirstName = z.FirstName,
    UserLastName = z.LastName,
    Email = lower(substring(z.FirstName, 1, 1) + z.LastName + '@heartyhearth.com'),
    Alert = 'Your recipe ' + '[' + z.recipename + ']' + ' is sitting in draft for ' + '['
    + convert(varchar, z.DraftHours) + ']' + ' hours. That is ' + '['
    + convert(varchar, z.DraftHours - z.AvgHours) + ']' + ' hours more than the average ' + '['
    + convert(varchar, z.AvgHours) + ']' + ' hours all other recipes took to be published.'    
from z

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select 
    EmailBody = 'Order cookbooks from HeartyHearth.com! We have ' 
    + convert(varchar, count(c.CookbookId)) 
    + ' books for sale, average price is $' 
    + convert(varchar, str(avg(c.Price), 10, 2))
    + '. You can order them all and receive a 25% discount, for a total of $' 
    + convert(varchar, str(sum(c.Price) * 0.75, 10, 2)) 
    + '. Click <a href = "www.heartyhearth.com/order/' 
    + convert(varchar(36), newid()) 
    + '">here</a> to order.'
from cookbook c
where c.CookbookStatus = 1
