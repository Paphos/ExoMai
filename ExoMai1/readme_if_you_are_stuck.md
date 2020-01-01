## Hints
- Create a IZooRepository interface and a XmlZooRepository class that implements this interface.
- Use dependency injection to use your repository in your service.
- You can use extension methods or a helper class to convert AnimalModel to AnimalXmlEntry and vice versa.
- One of the tricky will probably be the 'enum' conversion of the Color property. You can remove this field from the model at first and then put it back later to deal with it after everything else works!
- The folder 'sample' contains an XML file with 2 animals as example. You can use it in your development.