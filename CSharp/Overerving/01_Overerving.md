# Overerving

Om code zo veel mogelijk te herbruiken, is het soms interessant om classes
van elkaar te laten overerven.

> Dit is niet de enige reden om overerving te gebruiken. Een andere reden
is [Polymorfie](02_Polymorfie).

In wat volgt, willen we `Varken`, `Koe` en `Paard` een method `MaakGeluid()`
geven.

> Ze zullen respectievelijk *knor knor*, *moeeeee* en *hinnik hinnik* als
geluiden maken.

Omdat van elk dier ook nog het gewicht moet bijgehouden worden,
willen we vermijden dat we in elke class opnieuw dit gewicht moeten
definiëren.



## Refactoren

B.v. de class `Paard` ziet er zo uit:

```
class Paard {
  public double Gewicht { get; set; }
} 
```

Maar zo zien eveneens de classes `Varken` en `Koe` er uit.

Het is dus beter om een gemeenschappelijke *moeder*-class te maken, `Dier`:

```
class Dier {
  public double Gewicht { get; set; };
}
```

en de andere classes hiervan over te laten erven:

```
class Paard : Dier {

}

class Varken : Dier {

}

class Koe : Dier {

}
```

Op deze manier hebben we 3 classes gemaakt die allemaal de property `Gewicht`
hebben.

We zijn nu klaar om de classes uit te breiden met elk hun eigen 
`MaakGeluid()`-method.



## Uitbreiding

We breiden elke class uit met de method:

```
class Paard : Dier {
  public void MaakGeluid() {
    Console.WriteLine("hinnik hinnik");
  }
}

class Varken : Dier {
  public void MaakGeluid() {
    Console.WriteLine("knor knor");
  }
}

class Koe : Dier {
  public void MaakGeluid() {
    Console.WriteLine("moeeee");
  }
}
```

en nu kunnen we ze b.v. zo gebruiken:

```
Paard p = new Paard();
Varken v = new Varken();
Koe k = new Koe();

p.Gewicht = 102.2;
p.MaakGeluid();
Console.WriteLine(p.Gewicht);

v.Gewicht = 67.3;
v.MaakGeluid();
Console.WriteLine(v.Gewicht);
```

En we kunnen nu zelfs een type `Dier` gebruiken:

```
Dier d = new Paard();

d.Gewicht = 132.3;
d.MaakGeluid(); // foutmelding
```

`d.MaakGeluid()` zal echter een foutmelding geven omdat de class `Dier` de method
`MaakGeluid()` niet kent. Ze heeft echter wel een gewicht.

Het is ook geen probleem om de `Paard()`-constructor te gebruiker om een nieuw
`Dier` te maken. Een `Paard` **is** immers een `Dier`.



## Kortom

Één v.d. dingen die overerving ons toelaat is **gemeenschappelijke code** te
**herbruiken**.
