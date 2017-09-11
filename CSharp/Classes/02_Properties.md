# Properties

## Intro

**Properties** zijn zeer gelijkaardig aan **methods** in die zin dat ze
mee in staan voor de *publieke interface* v.d. class. M.a.w. : ze 
bepalen mee hoe de class kan gebruikt worden.

Denk bij properties aan **eigenschappen**, zoals b.v.

```
Button b = new Button();

b.BackgroundColor = ...
b.Text = ...
```

Terwijl methods **acties** bevatten:

```
b.Clear();
```

> Naast **Properties** en **methods** bevatten Windows Forms Controls ook nog
**events** (voorgesteld in VS door een bliksemschicht).


## Geschiedenis

Eigenlijk zijn properties overbodig 
([*syntactic sugar*](http://en.wikipedia.org/wiki/Syntactic_sugar)).

In Java is het b.v. de gewoonte om met *get*- en *set*-methodes te werken,
b.v.

```
class Varken {

  private double gewicht;
  
  double getGewicht() {
    return gewicht;
  }
  
  void setGewicht(double gewicht) {
    this.gewicht = gewicht;
  }

}
```

En dit kan je dan zo gebruiken:

```
Varken piggie = new Varken();

piggie.setGewicht(90.0);
double g = piggie.getGewicht();
```

Dit is ook perfecte C#-code maar hier hebben we **properties**
zodat de code zou worden:

```
Varken piggie = new Varken();

piggie.Gewicht = 90.0;
double g = piggie.Gewicht;
```


## Manuele properties

De volledige implementatie (get + set) van een property in C#:

```
class Varken {

  private double gewicht;
  
  public double Gewicht {
    get {
      return gewicht;
    }
    set {
      gewicht = value;
    }
  }
}
```

We kunnen ook kiezen voor een **Read-Only**-property:

```
class Koe {

  private double gewicht;
  
  public double Gewicht {
    get {
      return gewicht;
    }
  }
}
```

Of voor een Write-Only-property maar dit komt zelden voor.


## Automatic properties

In de laatste versies van C# heeft men weer wat *syntactic sugar*
toegevoegd: **Automatic Properties**.

Dit volstaat nu:

```
class Paard {
  public double Gewicht { get; set; }
}
```

Op deze manier hebben we zowel een get- als set-property.

Er is nu **geen** private variabele meer aanwezig,
waardoor we ook binnen de class zelf de property-naam
moeten gebruiken. Dat is niet erg:

```
class Paard {
  public double Gewicht { get; set; } // de automatic property Gewicht
  
  public string Info { // de Read-Only property Info
    get {
      return "Het paard weegt " + this.Gewicht + " kg";
    }
  } 
}
```

> Opgelet: maak niet per ongeluk een public variabele.
Je moet ook bij automatische properties nog wel degelijk de `{get; set;}`
er bij zetten. 



## Nog een voorbeeld

De class `Temperatuur` bevat een (automatic) property `Celsius` waarmee
een temperatuur kan gezet (en verkregen) worden:

```
class Temperatuur
{
    public double Celsius { get; set; }
    public double Fahrenheit
    {
        get
        {
            return (9/5) * Celsius + 32;
        }
    }
    public double Kelvin
    {
        get
        {
            return Celsius + 273.15;
        }
    }
} 
```

We kunnen ze b.v. zo gebruiken:

```
Temperatuur t = new Temperatuur();

t.Celsius = 23;
Console.WriteLine(t.Celsius);
Console.WriteLine(t.Fahrenheit);
Console.WriteLine(t.Kelvin); 
```
