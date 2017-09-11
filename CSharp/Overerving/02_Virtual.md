# Virtual en override

In het vorige voorbeeld kon je `MaakGeluid()` van een `Dier` niet aanroepen.

Toch kan het handig zijn om `Dier` al op de hoogte te brengen van het feit
dat de overervende classes deze method zullen hebben. Dit kan met `virtual`:

```
class Dier
{
    public double Gewicht { get; set; }

    public virtual void MaakGeluid()
    {
        Console.WriteLine("<stilte>");
    }
} 
```

De overervende classes moeten nu `override` gebruiken:

```
class Paard : Dier
{
    public override void MaakGeluid()
    {
        Console.WriteLine("hinnik hinnik");
    }
} 
```

> Ook **properties** kan je `virtual` maken en `override`n.



## Polymorfie

Aangezien `Dier` nu zelf een method `MaakGeluid()` heeft kan je ze nu ook
op een `Dier` aanroepen.

**Maar dat is niet alles!!**

Omdat de method `virtual` is, zal bij elke aanroep naar het **echte** type
v.h. object worden gekeken om te bepalen welke `MaakGeluid` moet aangeroepen
worden.

Deze code zal daarom `Paard.MaakGeluid()` aanroepen:

```
Dier d = new Paard();

d.MaakGeluid();
```

Terwijl deze code `Varken.MaakGeluid()` zal aanroepen:

```
Dier d = new Varken();

d.MaakGeluid();
```

We noemen dit **polymorfie**: een object van type `Dier` kan verschillende
vormen aannemen, nl. elk van zijn kind-classes.

Om polymorfie te laten werken, moet de polymorfe method dus wel
`virtual` zijn!



## Wat zonder polymorfie?

We gaan even terug in de tijd in een wereld zonder overerving.
Hoe zou voorgaande code er uit zien?

B.v. zo:

```
class OudDier
    {
        public enum SoortEnum { Paard, Varken, Koe };

        public SoortEnum Soort { get; set; }
        public double Gewicht { get; set; }

        public void MaakGeluid()
        {
            switch (this.Soort)
            {
                case SoortEnum.Paard:
                    Console.WriteLine("hinnik hinnik");
                    break;
                case SoortEnum.Varken:
                    Console.WriteLine("knor knor");
                    break;
                case SoortEnum.Koe:
                    Console.WriteLine("moeeee");
                    break;
            }
        }
    } 
```

Elke keer als we een nieuwe soort toevoegen, zou de oorspronkelijke class
moeten veranderen.



## Kortom

Dankzij overerving (en `virtual` en `override`):

- kunnen classes uitgebreid worden zonder dat ze moeten aangepast worden
- is de code beter geëncapsuleerd
- moet er (in bovenstaand voorbeeld) aan de code die gebruikt maakt van `Dier` 
niets meer veranderd worden om toekomstige `Dier`en te ondersteunen.
