# Parameters

Methodes kunnen parameters hebben.
Daardoor worden ze herbruikbaarder.

We geven de functie `Groet(...)` een parameter `naam` (van type `string`).
Bij de aanroep zijn we nu verplicht de `naam` als argument mee te geven.

```cs
class Program {

  static void Groet(string naam) {
    Console.WriteLine("Hallo {0}!", naam);
  }

  static void Main() {
    Groet("Jos");
  }
}
```
