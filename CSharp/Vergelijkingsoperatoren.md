# Vergelijkingsoperatoren

Het resultaat van een vergelijking is een `bool` (`true` of `false`):

> Stel dat we eerst 2 `int`'s `a` en `b` definiëren:

```cs
int a = 4;
int b = 8;
```

| operator | omschrijving          | voorbeeld          |
|----------|-----------------------|--------------------|
| `>`      | groter dan            | `bool r = a > b;`  |
| `<`      | kleiner dan           | `bool r = a < b;`  |
| `>=`     | groter of gelijk aan  | `bool r = a >= b;` |
| `<=`     | kleiner of gelijk aan | `bool r = a <= b;` |
| `==`     | gelijk aan            | `bool r = a == b;` |
| `!=`     | niet gelijk aan       | `bool r = a != b;` |

Vergelijkingsoperatoren worden b.v. gebruikt in een `if`-voorwaarde:

```cs
if(a > b) {
    Console.WriteLine("{0} is groter dan {1}.", a, b);
} else if(a < b) {
    Console.WriteLine("{0} is kleiner dan {1}.", a, b);
} else {
    Console.WriteLine("{0} is gelijk aan {1}.", a, b);
}
```

## Voorbeelden

https://dotnetfiddle.net/5up6Og : vergelijkingsoperatoren voor komma-getallen

## Denkoefening

Wat doet deze code?

```cs
bool b = 2 == 2;
```

> TIP: maak onderscheid tussen:
> - `=`, de toekenningsoperator
> - `==`, de vergelijkingsoperator om te controleren of 2 variabelen gelijk zijn

