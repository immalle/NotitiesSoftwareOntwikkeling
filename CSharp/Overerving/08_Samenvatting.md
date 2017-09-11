# Samenvatting / Tips

- een `abstract` method **moet** je overriden; 
een `virtual` method **kan** je overriden

## i.v.m. constructors

- als je geen constructors definieert, bestaat enkel de standaard-constructor
zonder parameters; vanaf je 1 constructor definieert, wordt deze standaard-
constructor verwijdert!
- constructors v.e. overervende class roepen **automatisch** de default-
constructor (dus die zonder parameters) v.d. moeder-class aan; als de moeder-
class geen default constructor heeft, moet via `: base(...)` de juiste
moeder-class-constructor aangeroepen worden

### voorbeeld 1

Een class zonder een constructor gedefinieerd:

```
class Persoon
{
  public string Naam { get; set; }
}
```

krijgt standaard een *default constructor* **zonder parameters**:

```
Persoon p = new Persoon();

p.Naam = "Jos";
```



### voorbeeld 2

Een class met een constructor gedefinieerd met b.v. 1 parameter:

```
class Persoon
{
  private string naam;
  
  public Persoon(string naam)
  {
    this.naam = naam;
  }
  
  public string Naam { 
    get 
    {
      return naam;
    }
}
```

kunnen we alleen nog maar gebruiker door 1 argument mee te geven:

```
Persoon p = new Persoon("Jos");

Console.WriteLine(p.Naam);
```



### voorbeeld 3

Een overervende class zonder constructors gedefinieerd, heeft zelf uiteraard
ook weer de *default constructor* **zonder** parameters:

```
class Persoon
{
  public string Naam { get; set; }
}

class Leerling : Persoon
{
  public string Klas { get; set; }
}
```

```
Leerling lln = new Leerling();

lln.Naam = "Jos";
lln.Klas = "5IB";
```



### voorbeeld 4

In deze classes heeft `Persoon` nog steeds de *default constructor* maar 
`Leerling` heeft nu enkel nog de gedefinieerde constructor met 1 parameter.

```
class Persoon
{
  public string Naam { get; set; }
}

class Leerling : Persoon
{
  public string Klas { get; set; }
  
  public Leerling(string klas)
  {
    Klas = klas;
  }
}
```

We moeten nu dus bij het aanmaken v.e. leerling de `klas` meegeven:

```
Leerling lln = new Leerling("5ib");
lln.Naam = "Jos";
```



### voorbeeld 5

Tot slot zien we in dit voorbeeld de *moeilijkste* mogelijkheid.

De constructor van `Persoon` **moet** een `naam` meekrijgen als argument.
De constructor van `Leerling` **moet** een `klas` meekrijgen als argument.

De overervende class `Leerling` probeert nu de *default constructor* van 
`Persoon` aan te roepen, maar die bestaat niet!

```
class Persoon
{
  private string naam;
  
  public Persoon(string naam)
  {
    this.naam = naam;
  }
  
  public string Naam { 
    get 
    {
      return naam;
    }
}

class Leerling : Persoon
{
  public string Klas { get; set; }
  
  public Leerling(string klas)
  {
    Klas = klas;
  }
}
```

> Bovenstaande code vind je ook op https://dotnetfiddle.net/HXvbrM 

Wat kunnen we nu doen om deze code toch werkend te krijgen?

De meest logische manier is om ervoor te zorgen dat als een `Leerling`
aangemaakt wordt, zowel `naam` als `klas` moeten opgegeven worden. Maar
aangezien we ook nog steeds `Persoon`en willen kunnen aanmaken, kunnen we dus
maar beter de `Persoon`-constructor herbruiken. Dit kunnen we zo oplossen:

```
class Leerling : Persoon
{
  public string Klas { get; set; }
  
  public Leerling(string naam, string klas) : base(naam)
  {
    Klas = klas;
  }
}
```

In deze code roept de constructor van `Leerling` de constructor van zijn basis-
klasse `Persoon` aan met de parameter `naam` die hij zelf net doorgekregen
heeft.

Gebruik de debugger in VS. Zet een breekpunt op deze regel:

```
Leerling lln = new Leerling("Jos", "5IB");
```

en kijk wat er gebeurt als je telkens `Step into` kiest.
