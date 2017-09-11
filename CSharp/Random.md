# Random getallen

Willekeurige getallen genereren is niet altijd gemakkelijk voor een computer.
Vooral **cryptografisch veilige** willekeurige getallen is een onderwerp op
zich.

We zullen wel gebruik leren maken van **pseudo**-Random generators.

## Random-class

Maak een instantie v.d. `Random`-class.
Je kan nu de `Next`-method gebruiken om willekeurige getallen te berekenen.

```
var rndGen = new Random();
Console.WriteLine(rndGen.Next());
```

> Zoek zelf de documentatie van de `Random`-class voor meer voorbeelden.

## Seed probleem

De `Random`-class is dus geen echte random-generator maar een pseudo-random-
generator. De opeenvolgende sequentie van zogezegde willekeurige getallen
wordt volledig bepaald door de **Seed**-waarde die met de constructor wordt
meegegeven.

Dit voorbeeld zal steeds dezelfde *random* getallen afprinten:

```
var rndGen = new Random(10); // seed-waarde van 10
Console.WriteLine(rndGen.Next());
Console.WriteLine(rndGen.Next());
```

Als je een `Random`-object maakt zonder de constructor parameters mee te geven,
wordt de **huidige tijd** als seed-waarde gebruikt.

Dit kan je zelf nagaan in :

https://dotnetfiddle.net/cfWYrj
