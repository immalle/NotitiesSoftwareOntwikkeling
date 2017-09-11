# Abstract

In het vorige voorbeeld had `Dier` een method `MaakGeluid()` maar erg nuttig
was die niet.

Vaak is het beter om met een **abstracte moeder-class** te werken.

Abstracte classes kunnen zelf niet geïnstantieerd worden.
Ze zijn er eigenlijk enkel om polymorfie mogelijk te maken.

Vanaf dat een class 1 abstracte method of property heeft, is het een
abstracte class. Het is immers niet mogelijk een object te maken v.e.
abstracte class omdat ze niet volledig is.



## Een abstracte method

Als we `MaakGeluid()` een abstracte method willen maken, vervangen
we `virtual` door `abstract`.

Het is nu ook verplicht om de class in zijn geheel als `abstract`
te benoemen!

```
abstract class Dier
{
    public double Gewicht { get; set; }

    public abstract void MaakGeluid();
} 
```

Abstracte classes kunnen nog wel andere properties of methods hebben
die **niet** abstract zijn. We willen immers nog zoveel mogelijk code
laten herbruiken door overervende classes.

Een abstracte method is dus een manier om de overervende classes te
**verplichten** deze method te implementeren. Daarom is het vaak een 
goed idee om methods abstract te maken.



## Een abstracte property

Aangezien properties in gebruik vrij gelijkaardig zijn aan methods
(denk aan `get` en `set`), kunnen we ze ook abstract maken.

De class `Persoon` heeft 2 abstracte properties.
We verplichten de overervende class dus deze 2 properties te overriden:

- `Naam` moet zowel een *getter* als een *setter* hebben
- `Leeftijd` mag enkel een *getter* hebben

De property `Geboortedatum` is een gewone automatic property.

```
abstract class Persoon
{
    public abstract string Naam { get; set; }
    public DateTime Geboortedatum { get; set; }
    public abstract int Leeftijd { get; }
}
```

Vervolgens maken we 2 classes die iets speciaals doen met zowel
`Naam` als `Leeftijd`.


```
class Aardling : Persoon
{
    private string naam;
    public override string Naam
    {
        get
        {
            return "Aardling " + naam;
        }
        set
        {
            naam = value;
        }
    }
    public override int Leeftijd
    {
        get
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Geboortedatum.Year;
            if (Geboortedatum > today.AddYears(-age)) age--;
            return age;
        }
    }
}
```

```
class Marsman : Persoon
{
    private string naam;
    public override string Naam
    {
        get
        {
            return "Marsman " + naam;
        }
        set
        {
            naam = value;
        }
    }
    public override int Leeftijd
    {
        get
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Geboortedatum.Year;
            if (Geboortedatum > today.AddYears(-age)) age--;

            // convert to Mars-years (see http://www.exploratorium.edu/ronh/age/)

            double leeftijd = age;
            leeftijd /= 1.8;

            return (int)leeftijd;
        }
    }
}
```

Het volgende programma demonstreert:

```
class Program
{
    static void Main(string[] args)
    {
        Persoon a = new Aardling();
        Persoon m = new Marsman();

        a.Naam = "Jos";
        a.Geboortedatum = new DateTime(1990, 1, 1);
    
        m.Naam = "Chnoo'zsch"; 
        m.Geboortedatum = new DateTime(1990, 1, 1);

        Console.WriteLine("{0} is {1} jaar.", a.Naam, a.Leeftijd);
        Console.WriteLine("{0} is {1} jaar.", m.Naam, m.Leeftijd);
    }
} 
```