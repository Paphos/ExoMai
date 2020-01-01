# Exo Mai 1

## Context
Welcome to the zoo!!🦁🐘
The API user should be able to see all the animals in the zoo, as well as add new ones.
Animals are represented by AnimalModel objects.

## Goal
Write the ZooService class in order to save and read animals from a XML file.
With the 'add' endpoint, the user will be able to add a new animal in the XML file.
With the 'getall' endpoint, the user will be able to get all the animals that are in the XML file.

## Constraints
- You must use the AnimalXmlSerializer located in the project ExoLibXml to perform the XML serialization.
- You will treat ExoLibXml as if it were an external library. Therefore, you cannot modify the code of ExoLibXml.
- Organize your code in a way that if we decide to use another library to store the animals later, there won't be a single line of code to change in either the controller or the service.

## Hints
- I encourage you to find the solutions by yourself. If you are stuck though, you can see the "readme_if_you_are_stuck.md" file (and ask me questions obviously!! =P)

## Concepts
- Dependency injection
- Separation of concerns / Decoupling
- Using external code
