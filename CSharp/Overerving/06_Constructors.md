# Constructors overerven

Op het eerste zicht lijken constructors en overerving niet zo moeilijk.
Toch schuilen er enkele addertjes onder het gras.



## Gemakkelijke constructors

Stel dat we van een `Paard` op het moment van zijn creatie een `gewicht`
willen meegeven.

Dat kan met volgende constructor:

```
class Paard : Dier
{
    public Paard(double gewicht)
    {
        base.Gewicht = gewicht;
    }

    public override void MaakGeluid()
    {
        Console.WriteLine("hinnik hinnik");
    }
} 
```

> We zetten constructors meestal bovenaan in de class, net onder de
class-variabelen.

Va. nu zijn we **verplicht** om bij de constructie v.e. `Paard` telkens
het gewicht mee te geven. De default constructor (zonder parameters)
verdwijnt immers van zodra we 1 andere constructor definiëren.

Desgewenst zouden we de constructor nog verder kunnen *overloaden*.



## Herbruik van code

Wat als we nu ook het `Varken` en de `Koe` op deze manier willen
construeren?

We zouden natuurlijk dezelfde constructor nog 2 maal kunnen implementeren
maar dan zijn we weer code aan het herschrijven. Dat moet beter kunnen!



## Een constructor voor alle overervende classes

Hier definiëren we de constructor in de basis-klasse `Dier`.
De default-constructor (zonder parameters) is va. nu dus niet meer beschikbaar.

```
abstract class Dier
{
    public virtual double Gewicht { get; set; }

    public Dier(double gewicht)
    {
        this.Gewicht = gewicht;
    }
    
    public abstract void MaakGeluid(); 
}
```

In bovenstaand voorbeeld lijkt de constructor misschien nutteloos.
`Dier` is immers een abstracte class waar we niet rechtstreeks een object
van kunnen maken. Het doel is echter om de code in de constructor te kunnen
**herbruiken** in de overervende classes!



## Is de constructor overgeërfd?

Als we nu een `Paard` proberen te construeren, kunnen we deze constructor
echter nog niet gebruiken.

Constructors worden immers **niet** automatisch mee overgeërfd!

> De redenering is dat elke class verantwoordelijk moet zijn voor zijn
eigen creatie en we hier zorgvuldig mee moeten omspringen!

We definiëren daarom voor `Paard` een zelfde constructor:

```
public Paard(double gewicht)
{
    base.Gewicht = gewicht;
} 
```

> Merk op dat we hier i.p.v. `base` even goed `this` hadden kunnen
gebruiken omdat `Gewicht` toch een public property is.

maar helaas zal dit voor een compiler-fout zorgen:

```
'Dieren.Dier' does not contain a constructor that takes 0 arguments 
```

Wat is hier aan de hand?

Het probleem met constructors in overervende classes is dat zij
eerst nog de basisklasse moeten construeren. 

> Overervende classes breiden de basis-klasse immers verder uit
dus ook de basis-klasse moet geconstrueerd worden.

Er moet dus ook een constructor van `Dier` aangeroepen worden. 
Helaas is er geen *default constructor* meer beschikbaar.

We moeten nu dus **expliciet** aangeven welke constructor v.d.
base-class we willen aanroepen.

Dit kan zo:

```
public Paard(double gewicht)
    : base(gewicht)
{

} 
```

Met deze syntax zeggen we dus dat als een `Paard`-object geconstrueerd
wordt, de parameter `gewicht` moet worden doorgegeven aan de base-class.
De constructor v.d. base-class neemt het verder over.

Op deze manier is ons doel van *herbruikbare constructor-code* dus
gerealiseerd: alle overervende classes moeten simpelweg via `: base(...)`
de base-constructor aanroepen. Ze moeten wel de gepaste argumenten (`gewicht`)
doorgeven aan de base-constructor.



## Wat met de andere classes

`Varken` en `Dier` hebben nog steeds enkel hun default-constructor.
Ze hebben nu echter ook hetzelfde probleem dat `Paard` eerder had:
ze vinden in hun base-class geen constructor meer zonder parameter.

Dit kan op 2 manieren opgelost worden:

- Creër alsnog manueel een constructor in `Dier` zonder parameters
(de vervanger v.d. default-constructor).
- Gebruik de `: base(0)`-syntax

Deze laatste heeft waarschijnlijk de voorkeur:

```
class Varken : Dier
{
    public Varken()
        : base(0)
    {

    }

    public override void MaakGeluid()
    {
        Console.WriteLine("knor knor");
    }
} 
```

We moeten nu in `Varken` dus expliciet een constructor zonder parameters
aanmaken die ook de base-class-constructor met een gepast argument (`0`)
aanroept.

Deze werkwijze heeft het voordeel om wat explicieter te zijn, zodat de code
meestal beter leesbaar wordt.
