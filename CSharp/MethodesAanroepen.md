# Methodes aanroepen

Een method-aanroep is steeds te herkennen aan de ronde haken `()`. Tussen de haken kunnen
we **argumenten** meegeven.

Voorbeelden:

```cs
Console.WriteLine("Hallo");                 // WriteLine met 1 string-argument. WriteLine is een static method van de class Console
paperCanvas.Children.Add(ellipse1);         // De Add-method met 1 parameter (een Ellipse object) van een object gereturnt door de property Children (Children is van type UIElementCollection)
```

Sommige van deze methods, hebben een **return-waarde**.

Voorbeelden:

```cs
string s = Console.ReadLine();              // ReadLine zonder argumenten met string-return waarde
int i = Convert.ToInt32(6.4);               // ToInt32 met 1 double-parameter en int-return waarde
double x = Math.Floor(4.6);                 // Floor is een static method van de class Math
double y = Math.Round(4.6);
```

De return-waarde kan worden opgeslagen in een variabele met de
**toekenningsoperator** (`=`).

Het is niet omdat een method een return-waarde heeft, dat we er ook iets
mee **moeten** doen.

B.v.

```cs
Console.ReadLine();
```

heeft als return-waarde hetgeen de gebruiker ingetypt heeft maar hier
wordt deze waarde gewoon weggegooid. We gebruiken `ReadLine()` hier enkel
opdat de gebruiker op `<ENTER>` zou moeten drukken om verder te gaan.


# Oefeningen

## ReadLine returnt een string 

https://dotnetfiddle.net/YhB3Oz

```cs
public class ReadLineExample
{	
	public static void Main()
	{
		Console.Write("Geef je naam: ");
		string naam = Console.ReadLine(); // de method ReadLine returnt een string
		Console.WriteLine("Hallo {0}", naam);
	}
}
```

## Math-functies

https://dotnetfiddle.net/hVw5r4

Sommige Math-functies (zoals `Math.Max`) hebben 2 (of meer) parameters nodig:

```cs
double x = -2.18;
double y = 3.23;
double z = Math.Max(x, y);
Console.WriteLine("Het grootste getal van {0} en {1} is {2}.", x, y, z);
```

of korter:

```cs
Console.WriteLine("Het grootste getal van {0} en {1} is {2}.", 
	          -2.18, 3.23, Math.Max(x, 3.23));
```
