# Exo Mai 4

## Context
Over the years, I built a useful set of tools that I can use in various projects and situations.
Believe it or not, one of the most useful ones so far are custom dictionaries!
To name a few, I have made the "_two-key dictionary_" for example. 
It's like a regular dictionary (a set of key-value pair), but the key is always made of two elements.
Another one that I like is the "_dictionary of list_". I use this one very frequently!
As you can tell by the name, it's a dictionary that can hold multiple values for each key. Handy!

## Goal
- Create the `DictionaryOfList` class that implements the `IDictionaryOfList` interface.
- That means 3 properties and 7 methods to implements.
- Add it in the method `CreateDictionaryOfList()` method of the class `DictionaryOfListTest` so you can run the unit tests!
- All tests in `DictionaryOfListTest` must pass! =)

## Hints
- Now you gonna dive into the marvelous realm of "generic types", which can be a little tricky...
- You can look at my other class `TwoKeyDictionary` to understand how to implement a generic collection. Especially for the syntax! You don't need the `TwoKeyDictionary` in your actual code but the implementation of the `DictionaryOfList` should be a bit similar. And you can check the `TwoKeyDictionaryTest` class to see how it works from the outside.
- The assignment is mostly about syntax. If my example is not enough to understand, feel free to check other examples of generic collections on the web!
- A `DictionaryOfList<TKey,TItem>` is pretty much a wrapper for a `Dictionary<TKey,List<TItem>>` ...

## Difficulty
- Algorithmic: ++
- Object-oriented: +
- Syntax: ++++

## Concepts
- C# syntax
- Collections
- Generic types
