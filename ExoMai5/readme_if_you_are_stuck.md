# Read me (only) if you are stuck!!

Here is the list of all the LINQ methods that I used to resolve each problem. Maybe you will find different solutions than mine but this can give you hints to solve the most difficult ones :

## Level 1

### GetTotalPopulation
<details>
  <summary>Click to show!</summary>
Sum
</details>

### GetCitiesStartingWithSaint
<details>
  <summary>Click to show!</summary>
Where (+ StartsWith)
</details>

### IsThereACityThatHasExactly10000Inhabitants
<details>
  <summary>Click to show!</summary>
Any
</details>

## Level 2

### GetTheCityWithTheLongestName
<details>
  <summary>Click to show!</summary>
OrderByDescending + First
</details>

### GetThe10MostPopulatedFrenchCities
<details>
  <summary>Click to show!</summary>
OrderByDescending + Take
</details>

### GetAllDepartments
<details>
  <summary>Click to show!</summary>
Select + Distinct
</details>

### GetNumberOfCityInCorsica
<details>
  <summary>Click to show!</summary>
Where + Count
</details>

## Level 3

### GetAllDuplicateCityNames
<details>
  <summary>Click to show!</summary>
GroupBy + Where + Count + Select
</details>

### GetTheNumberOfFrenchPeopleThatDontLiveInThe10MostPopulatedCities
<details>
  <summary>Click to show!</summary>
OrderByDescending + Skip + Sum
</details>

### GetThe3BiggestAndThe3SmallestCities
<details>
  <summary>Click to show!</summary>
Where + OrderBy + Take + Concat + OrderByDescending
</details>

### GetTheMostPopulatedDepartment
<details>
  <summary>Click to show!</summary>
GroupBy + Select + Sum + OrderByDescending + First
</details>