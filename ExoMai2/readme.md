# Exo Mai 2

The Visual Studio is divided into two distinct assignments.

# A) Learning Dictionary

## Context
Some travelers want to keep track of how many countries they visited. 🌍

## Goal
Implement the method `TravelerHelper.GetNumberOfCountryVisitedByTravellers()`
Given a list of travelers, the method must returns a dictionary with:
- as key: the name of the traveler (`string`)
- as value: how many countries did this traveler visit? (`int`)

All the unit tests in `TestExerciceA/TravelerHelperTest` must pass, without modifying them of course ^^'

## Hints
- There is a little trap! If a traveler visited multiple cities of the same country, it still count as one country...
- You can use the `CityCountryMapping` class to solve this problem!

## Skills to learn
- Creating and using dictionaries (which can be really handy!)

## Difficulty
should be easy!

# B) Learning Queue

## Context
This peculiar city only allows a small number of travelers to go inside at the same time.

## Goal
- Implement the methods `Enter()` and `Leave()` from the class `VerySmallCity`.
- The maximum number of people allowed in the city is stored in the `_numberOfTravelerAllowedAtTheSameTime` attribute.
- If a traveler tries to enter the city when it's full, the traveler must wait at the border for an another traveler to leave.
- When a traveler enters the city, he will add this city to the list of the cities he visited.
- All the unit tests must pass! (those are located in `TestExerciceB/VerySmallCityTest`)

## Hints
You can use a queue to keep track of the travelers that wait at the border of the city.
(see https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1 )

When a traveler wants to enter the city, two possibilities :
- either he enters the city
- or he is added to the group of travelers that wait at the border.

When a traveler leaves the city, the first traveler that is waiting at the border gets to enter the city!

In order to simplify, we'll assume that a traveler cannot enter the same city multiple times.

## Skills to learn
- Using queues (useful for handling ordered events for example!)
- Design and implement a small algorithm

## Difficulty
slightly more challenging, but not that much =P