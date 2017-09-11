# Variabelen declareren

Een variabele is altijd v.e. bepaald **type**.

> Enkele veel gebruikte types:
> - gehele getallen (`int`)
> - komma-getallen (`double`)
> - tekst (`string`) 

Bij het **aanmaken** of **declareren** v.e. variabele, moeten we 2 dingen meegeven:

- het type
- de naam

```cs
int aantalKinderen;
string voornaam;
double prijs;
```

> Het is belangrijk om steeds duidelijke namen voor je variabelen te kiezen!

> Een afspraak is dat we variabelen meestal) met een **kleine letter** laten
> beginnen! In C# gebruiken we meestal `camelCase` i.t.t. `snake_case` in
> sommige andere programmeertalen.

## Voorbeelden

Het declareren van een variabele met de naam `x` van type `int`:

```cs
int x;
```

Het declareren van een variabele met de naam `d` van type `double`:

```cs
double d;
```

## Initialiseren

We kunnen ook meteen een waarde meegeven aan variabelen. We noemen dit **initialiseren**.

```cs
int aantalKamelen = 3;
double prijs = 99.95;
string naam = "Joske";
```

In dit geval mogen we het type vervangen door `var` omdat C# dan zelf kan
achterhalen welk type we bedoelen:

```cs
var aantalKamelen = 3;
var prijs = 99.95;
var naam = "Joske";
```

## Further Reading

- https://en.wikipedia.org/wiki/Naming_convention_(programming)
- https://en.wikipedia.org/wiki/Camel_case
- https://en.wikipedia.org/wiki/Snake_case

Meer info over de in C# beschikbare types:

- http://msdn.microsoft.com/en-us/library/s1ax56ch.aspx : Value Types 
- http://msdn.microsoft.com/en-us/library/ya5y69ds.aspx : Built-In Types (C#
  keywords - reference table)

