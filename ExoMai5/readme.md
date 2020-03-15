# Exo Mai 5

## Context
I found a big CSV file with all the name and population of the 36700 french cities (see villes_france.csv).
Sounds like a the perfect occasion to work with collections in C# and rehearse LINQ syntax !

## Goal
- Complete the 11 methods in `MyDataProcessor`.
- All tests in `MyDataProcessorTest` must pass! =)
- All methods must be implemented in **one single line** using LINQ queries.

## Remarks
- When I say "one single line", it means that you can use multiple chained LINQ methods (_= fluent_) like the following example, but there must be only one `;` in the whole method.
```csharp
// Example: Get the names of the cities that have less than 100 inhabitants
public void GetNameOfCitiesThatHaveLessThan100Inhabitants()
{
	return _cities.Where(city => city.Population < 100)
		.Select(city => city.Name);
}
```
- In the above example, I am using 2 LINQ methods (`Where` and `Select`). The 11 methods to implements are divided in 3 difficulty level :
	- Level 1 : can be resolved with 1 LINQ methods
	- Level 2 : can be resolved by chaining 2 LINQ methods
	- Level 3 : can be resolved by chaining 3 or more LINQ methods
- Here is the complete list of the LINQ methods that I used to complete the assignment : `Any`, `Concat`, `Count`, `Distinct`, `First`, `GroupBy`, `OrderBy`, `OrderByDistinct`, `Select`, `Skip`, `Sum`, `Take` and `Where`
- If you search resources about LINQ on the web, you will probably come across the following SQL-like syntax (especially in official Microsoft documentation). Although this is a perfectly valid syntax, I find it to be not very readable or easy to use. We usually prefer the "IEnumerable extension methods" syntax in our projects so I'd prefer that you use this one to complete this assignment, and not the SQL-like one =) 
```csharp
// We rarely use this syntax anyway =P
    var numQuery =
        from num in numbers
        where (num % 2) == 0
        select num;
```

## Hints
- If you are stuck, you can read the _read_me_if_you_are_stuck.md_ file =)

## Difficulty
- Syntaxic: ++
- Algorithmic: +

## Concepts
- LINQ syntax
- Collections
