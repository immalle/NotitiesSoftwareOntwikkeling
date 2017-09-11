# Override

**Overriden** (overschrijven) doe je met methods die in een
bovenliggende class als **virtual** of **abstract** gedefinieerd zijn.


## Object

Elke class in C# erft over van `System.Object` die een interessante
`virtual` method heeft: `ToString()`.

> Een andere method van `System.Object` is `GetHashCode()`. Dit wordt
gebruikt om te controleren of 2 *reference*-types naar hetzelfde
object verwijzen.

Als je eigen class nood heeft aan een ToString-conversie, is het dus
best deze method te **overriden**:

```
abstract class Dier
{
    public virtual double Gewicht { get; set; }

    public abstract void MaakGeluid();
    
    public override string ToString()
    {
        return String.Format("Het dier weegt {0} kg.", this.Gewicht);
    }
} 
```

## Voorbeeld

https://dotnetfiddle.net/DcA3k4
