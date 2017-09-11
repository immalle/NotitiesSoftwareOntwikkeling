# This

In elke C#-class kunnen we `this` gebruiken.

Dit is een shortcut naar het huidige object.

In dit voorbeeld zijn er 2 variabelen met de naam `gewicht`:

- de class-variabele
- de parameter van de method `GokGewicht`

```
class Dier {
  private double gewicht;
  
  void GokGewicht(double gewicht) {
    if(gewicht > this.gewicht) {
      Console.WriteLine("Je gokte te hoog...");
    }
  }
}
```

Om het onderscheid te maken, gebruiken we `this`.

`this.gewicht` verwijst dus naar de class-variabele.

> De lokale variabele `gewicht`, de parameter van `GokGewicht(double gewicht)`,
> heeft voorrang op de class-variabele `private double gewicht`.

Je **mag** `this` steeds gebruiken maar vaak is dat overbodig.

In dit voorbeeld zie je beide manieren gebruikt:

```
class Lamp {
  private bool brandend;
  
  void SchakelAan()
  {
    this.brandend = true; // hier gebruik we `this` hoewel het eigenlijk niet nodig is
  }
  
  void SchakelUit()
  {
    brandend = false; // hier gebruiken we `this` niet er is immers toch geen verwarring mogelijk
  }
}
```

# Andere constructoren aanroepen

```
class A {

  public A() : this(DateTime.Now) {
  }
  
  public A(DateTime when) {
    Console.WriteLine("[{0}] Created an A-object with hashcode [{1}.], when, this.GetHashCode());
  }
  
}
```

of

```
class A {

  	public A() : this(DateTime.Now) { // using `this` to call other constructor-overload
  	}
  
	public A(DateTime when) {
		this.when = when; // using `this` to store class-variabele `when`
   		Console.WriteLine(this.ToString()); // using `this` to call method
  	}
	
	
	readonly private DateTime when;
	
	public override string ToString() {
		return String.Format("[{0}] Created an A-object with hashcode [{1}].", when, this.GetHashCode());
	}
  
}
```

Zie ook https://dotnetfiddle.net/PvJVDL

> Meerdere constructoren aanmaken kan een mooie manier zijn om te refactoren,
> net zoals het **extract**en van **method**s nuttig is. DRY (Don't Repeat Yourself)!

