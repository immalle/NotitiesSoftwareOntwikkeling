# Tijdsmetingen

## Algoritme

De techniek bestaat er in om op 2 tijdstippen de huidige tijd vast te leggen:

- vlak **voor** het uitvoeren van de te meten code
- vlak **na** het uitvoeren van de te meten code

Nadien kan het verschil van de 2 tijden (een `TimeSpan`) berekend worden.

# Profilen

*Profilen* is het uitzoeken waar de *bottle-neck* in snelheid (of geheugengebruik)
van een programma optreedt.

> Men zegt trouwens : **Premature optimization is the root of all evil**.
> D.w.z. dat je in eerste instantie duidelijke code moet schrijven
> en pas achteraf moet gaan uitzoeken waar er - **indien nodig** - 
> snelheidsverbeteringen kunnen doorgevoerd worden.

Er bestaan tools om uitgebreid te *profilen* maar met deze eenvoudige techniek
kan ook zijn nut bewijzen:

```
DateTime pre = DateTime.Now;

UInt64 sum = 0;
		
Console.WriteLine(UInt32.MaxValue);

for(UInt64 i = 0; i < UInt32.MaxValue; i++)
{
	sum += i;
}

DateTime post = DateTime.Now;
	
Console.WriteLine(post - pre);
```

> We gebruiken hier een `UInt64` opdat we een groot getal zouden kunnen opslaan.

> **Opmkering Opmkering Opmkering Opmkering Opmkering Opmkering Opmkering
> Opmkering :** Wat gebeurt er als `i` met `var` gedeclareerd wordt i.p.v. met `UInt64`? Waarom?

## Voorbeeld

Een voorbeeld waarbij we voor een getypte string, de gemiddelde invoersnelheid
per karakter berekenen:

```
static void Main(string[] args) {
    DateTime voor;
    DateTime na;

    TimeSpan verschil;
    double TimePerCharacter;
    
    string naam = "";

    Console.Write("Geef je naam: ");
    voor = DateTime.Now;
    naam = Console.ReadLine();
    na = DateTime.Now;
    
    verschil = na - voor;
    timePerCharacter = verschil.TotalSeconds / naam.Length;

    Console.WriteLine("Dag {0}. Je hebt er {1} seconden over gedaan om je naam van {2} karakters in te typen!", 
        naam, 
        verschil.TotalSeconds,
        naam.Length);
    Console.WriteLine("Dat is {0} ms per karakter.", timePerCharacter * 100);

    if(timePerCharacter > 0.50)
    {
        Console.WriteLine("Dat mag wel sneller!");
    }
}
```

> Merk op dat we eerst alle variabelen declareren!

# Voorbeelden

- https://dotnetfiddle.net/E0ckHf (Time limit exceeded error : probeer op eigen computer)

