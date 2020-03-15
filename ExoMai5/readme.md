# Exo Mai 5

## Context
I found a big CSV file with all the name and population of the 36700 french cities (see villes_france.csv).
Sounds like a the perfect occasion to work with collections in C# and rehearsing LINQ syntax !

## Goal
- Complete the 11 methods in `MyDataProcessor`.
- All tests in `MyDataProcessorTest` must pass! =)

## Remarks
- All methods must be implemented in **one single line** using Linq queries.
- When I say "one single line", it means that you can use multiple chained linq methods (_= fluent_) like the following example, but there must be only one ';' in the whole method.
```csharp
// Example: Get the names of the cities that have less than 100 inhabitants
return _cities.Where(city => city.Population < 100)
	.Select(city => city.Name);
```
- In the above example, I am using 2 Linq methods (`Where` and `Select`). The 11 methods to implements are divided in 3 difficulty level :
	- Level 1 : can be resolved with 1 Linq methods
	- Level 2 : can be resolved with 2 Linq methods
	- Level 3 : can be resolved with 3 or more Linq methods
- Here is the complete list of the Linq method that I used to complete the assignment : `Any`, `Concat`, `Count`, `Distinct`, `First`, `GroupBy`, `OrderBy`, `OrderByDistinct`, `Select`, `Skip`, `Sum`, `Take` and `Where`
- If you are stuck, you can read the `read_me_if_you_are_stuck.md` file =)

## Difficulty
- Syntaxic: ++
- Algorithmic: +

## Concepts
- Linq syntax
- Collections
