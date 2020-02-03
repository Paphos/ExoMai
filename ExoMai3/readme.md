# Exo Mai 3

## Context

_After a long walk across the forest, the hungry adventurers finally find the manor that they were looking for. As they enter the house, they see a wonderful buffet full of tasty food. No better occassion for them to regain their strength!_

Each adventurer has a score in Strength, Wisdom and Happiness. The food they eat can modify these numbers. For example, eating an apple gives a +5 bonus in Strength. Your goal is to implement these food items into C#!

## Instructions
- All food item must implements the interface IEnchantedFood
- The first item is already implemented as an example : the **Peanut**🥜 that gives +1 Happiness
- You must create the following items in order (growing difficulty) :
    - **Cookie**🍪 : +4 Happiness and -1 Wisdom
    - **Super cookie**🍪🌟⚡ : same effect than **Cookie** and +50 Strength. _(hint: you can use inheritance)_
    - From this point, every **fruit** will have a +2 Wisdom bonus. _(hint: use an abstract class)_
    - **Apple**🍎 : +5 Strength (and +2 Wisdom thanks to the fruit bonus)
    - **Raspberry**🍓🌸 : +4 Happiness (and also a fruit)
    - **Apple-raspberry pie**🥧 : A pie made of one apple and one raspberry so it combines the bonuses of both items and also has another bonus +10 Happiness. _(hint: you can use composition)_
    - **Candy**🍬 : +5 Strength **only if** the adventurer's current strength is below 10.
    - **Croissant**🥐 : same effect than the candy. The trick here: the code of this effect must be in one place, so the candy and the croissant must somehow use the same code _(hint: you can separate the food item from its effects and reuse it => composition, but at a more precise level than before)_
    - **Chocolate cake**🍫🎂 : TODO
- Every time you create an item, uncomment the related test in the UnitTasting project, and it should pass =)

## In the end...
- What are the benefits and drawbacks of inheritance? composition?

## Difficulty
- Algorithmic: ⭐
- Object-oriented: ⭐⭐
- Syntaxic: ⭐⭐

## Concepts
- Inheritance
- Composition
- Object-oriented design
- C# syntax
