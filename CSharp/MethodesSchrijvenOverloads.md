# Overloads van zelf geschreven methods

Deze class heeft 2 **overloads** van de method `Groet` :

- `void Groet()` zonder parameter
- `void Groet(string naam)` met een string als parameter

```cs
class Program {

  static void Groet() {
    Console.WriteLine("Hallo!");
  }
  
  static void Groet(string naam) {
    Console.WriteLine("Hallo {0}!", naam);
  }

  static void Main() {
    Groet();
    Groet("Jos");
    Groet("Jan");
  }

}
```

# Oefening

- Maak een nieuw Console-Applicatie in Visual Studio
- Definieer de 2 overloads van de method `Groet`
- Kijk hoe Visual Studio's *IntelliSense* de verschillende overloads laat zien,
  net zoals het dat voor methods uit de *.Net standard libbrary* doet.
  
