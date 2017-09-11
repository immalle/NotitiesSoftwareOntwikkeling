# Interfaces

In het .NET framework komen vele **interfaces** voor, zoals:

- `IEnumerable`
- `IList`
- `ICollection`
- `IFormatProvider` (gebruikt door `ToString()`)
- ...

En we kunnen uiteraard ook zelf interfaces maken, b.v.

```cs
public interface IBestuurbaar
{
    void Rij();
    void Draai(int graden);
}
```

Interfaces zou je kunnen beschouwen als *pure* abstracte classes: ze zeggen wat
een class moet doen maar zeggen niet hoe.

Interfaces worden **geimplementeerd** door classes met dezelfde syntax als
overerving.

Als een class dus de interface `IBestuurbaar` *implementeert*, moet deze
verplicht de methods `Rij()` en `Draai(int graden)` implementeren:

```cs
class Voertuig : IBestuurbaar
{
    public void Rij()
    {
        Console.WriteLine("Het voertuig rijdt.");
    }

    public void Draai(int graden)
    {
        Console.WriteLine("De auto draait {0} graden.", graden);
    }
} 
```

Visual Studio kan je hierbij enorm helpen: 

- type het volgende:

```cs
class Voertuig : IBestuurbaar
{
}
```

- klik rechts op `IBestuurbaar`
- kies `Implement Interface`, `Implement Interface Implicitily`



# Meerdere interfaces implementeren

Het is niet uitzonderlijk dat een class **meerdere** interfaces implementeert.
Een class kan maximaal van 1 andere (abstracte) class overerven maar kan
meerdere interfaces implementeren.



# Interfaces als ontwerpbeschrijving

Tijdens het ontwerpen van software wil je meestal zoveel opsplitsen in
afzonderlijk werkende delen. Interfaces zijn hiervoor iets beter geschikt dan
classes omdat je er nadien nog alle kanten mee uitkan.



# Interfaces voor onderlinge aansluiting

De belangrijkste reden om interfaces te gebruiken is om er zeker van te zijn
dat een class kan samenwerken met andere classes.

Als ik b.v. een class tegenkom die mijn `IBestuurbaar`-interface implementeert,
weet ik dat ik van deze class de `Rij()`- en `Draai(...)`-method kan gebruiken.

In het .NET framework wordt dit zeer veel gebruikt, b.v. als een class de 
`IEnumerable`-interface implementeert, kunnen we met `foreach` itereren over de
verschillende elementen.

> Je eigen classes kunnen uiteraard ook .NET-interface (zoals `IEnumerable`)
implementeren!



# Opmerking

Het is normaal niet nodig om access specifiers (`public`, `private`, ...) mee
te geven, aangezien een interface juist enkel de `public` members weergeeft.

Private members of implementaties van methods/properties in een interface
steken, heeft geen zin!
