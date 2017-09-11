# De scope van lokale variabelen en class-variabelen (en -methods)

**Scope** kan je vrij vertalen als **reikwijdte** of **zichtbaarheid**.

Door de code te **indenteren** (*uit te lijnen*) zie je gemakkelijker
de scope.

> Indentatie is voor de compiler niet nodig maar het is wel makkelijker
> te lezen voor ons, mensen.


## Code-blocks gescheiden door accolades

De accolades (`{` en `}`) markeren het begin en einde van een code-blok.

```cs
void PrintLeeftijd() {
  int leeftijd;
  leeftijd = 16;
  Console.WriteLine(leeftijd);
}
```

De scope van de variabele `leeftijd` ligt binnen de method `PrintLeeftijd`.


## Variabelen in class-scope

Een class kan methods maar ook variabelen bevatten:

```cs
class Persoon {

  string naam = "Joske";
  
  void PrintNaam() {
    Console.WriteLine(naam);
  }

  void PrintLeeftijd() {
    int leeftijd;
    leeftijd = 16;
    Console.WriteLine(leeftijd);
  }
}
```

Vaststellingen:

- De scope van `leeftijd` is nog steeds beperkt, nl. binnen de method
  `PrintLeeftijd`.
- De scope van `naam` is in de gehele class : `naam` kan gebruikt worden door
  alle methods binnen de class.
  

## Denkoefening

Als we een class `Persoon` maken, wat is dan de beste plek om de `naam`
en `leeftijd` te declareren?

- Binnen een method zoals bij `leeftijd`?
- Op class-niveau zoals bij `naam`?


## Methods in class-scope

In het voorbeeld zijn al deze class-members op dezelfde hoogte (indentatie)
gedefinieerd:

- de variabele `naam` 
- de method `PrintNaam`
- de method `PrintLeeftijd`

Ze hebben allen **class-scope**.

We kunnen dus nog een method `PrintInfo` toevoegen:

```cs
class Persoon {

  string naam = "Joske";
  
  void PrintNaam() {
    Console.WriteLine(naam);
  }

  void PrintLeeftijd() {
    int leeftijd;
    leeftijd = 16;
    Console.WriteLine(leeftijd);
  }
  
  void PrintInfo() {
    PrintNaam();
    PrintLeeftijd();
  }
}
```

Vaststellingen:

- de method `PrintInfo` maakt gebruik van 2 methods uit dezelfde class `Persoon`.

