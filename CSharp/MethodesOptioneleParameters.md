# Optionele Parameters

De parameters van methods kunnen optioneel zijn als een default-waarde wordt
meegegeven.

We geven de functie `Groet(...)` een parameter `naam` (van type `string`)
maar stellen deze ook gelijk aan `"Jos"`.
We zijn nu niet meer verplicht de `naam` als argument mee te geven.

```cs
class Program {

  static void Groet(string naam="Jos") {
    Console.WriteLine("Hallo {0}!", naam);
  }

  static void Main() {
    Groet();
    Groet("Jos");
  }
}
```
