# Return-waardes

Een method heeft altijd een return-type. In de vorige voorbeelden was dit `void`
(Engels voor *leegte*).

We hebben al enkele functies gebruikt die ook iets returnen:

- `Console.ReadLine()` returnt een `string`, nl. hetgeen de gebruiker heeft
ingetipt
- `Math.Round(getal, 2)` return een 2 cijfers na de komma afgeronde `double`
- ...


## Zelf methodes met return-waarde schrijven

Speciaal aan methodes met een return-waarde is dat ze op een bepaald moment
ook een object *returnen*. Dat gebeurt met het keyword `return` gevolgd
door het object dat moet gereturnt worden:

- Een method die een `string`-object returnt, doet b.v. `return "test";`.
- Een method die een `bool`-object returnt, doet b.v. `return false;`.
- Een method die een `int`-object returnt, doet b.v. `return 3;`.


## De GenereerGroet-methode

Hier zie je een methode `GenereerGroet` die een `string` returnt:

```cs
static string GenereerGroet(string naam) {
  return "Hallo " + naam;
}
```

In de volgende code maakt deze method deel uit van een class en wordt ze ook
aangeroepen:

```cs
class Program {

  static void Groet(string naam) {
    Console.WriteLine("Hallo {0}!", naam);
  }
  
  static string GenereerGroet(string naam) {
    return "Hallo " + naam;
  }

  static void Main() {
    Groet("Jos");
    Console.WriteLine(GenereerGroet("Willy"));
  }
}
```

## Oefening

- Maak een nieuwe WPF applicatie
- Zet een `Button` en een `Label` op het main window
- Voeg de `GenereerGroet`-method toe aan `MainWindow`
- Zorg dat na een klik op de knop, het `Label` inhoud krijgt die met
  `GenereerGroet` gemaakt is

> Werkt de `GenereerGroet`-method nog als je `static` weghaalt?

