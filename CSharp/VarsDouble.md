# Komma-getallen

## Declaratie en initialisatie

Declaratie van een komma-getal:

```cs
double x;
```

Declaratie + initialisatie van een komma-getal :

```cs
double x = 2.6;
```

## Rekenkundige operatoren

Variabelen van type `double` ondersteunen dezelfde rekenkundige operatoren als `int`.
Zie [Gehele getallen (int)](VarsInt.md).

## Varianten

Een `double` in C# komt overeen met het .NET type `System.Double`.

Er bestaat ook nog `float` wat overeen komt met `System.Single`.

Zie ook:

- https://dotnetfiddle.net/vO9YWt : overzicht van kleinst en grootste mogelijke waarden
- https://msdn.microsoft.com/en-us/library/9ahet949.aspx

## Voorbeelden

- https://dotnetfiddle.net/wOUaq7 : alle rekenkundige operatoren bij `double`'s
- https://dotnetfiddle.net/5up6Og : vergelijkingsoperatoren bij `double` 

## Further reading

Komma-getallen worden in een computer opgeslagen als binaire getallen. Hierdoor
zijn er soms afrondingsfouten waardoor je moet opletten met `==` en `!=`.

In het decimaal talstel vertoont de breuk `1/3` een herhalingspatroon:
`0.3333333333333`.

Hetzelfde gebeurt in het binair talstelsel met het getal `1/10` of `0.1`.

- https://en.wikipedia.org/wiki/Binary_number#Fractions
- http://stackoverflow.com/questions/1398753/comparing-double-values-in-c-sharp
- http://docs.oracle.com/cd/E19957-01/806-3568/ncg_goldberg.html


