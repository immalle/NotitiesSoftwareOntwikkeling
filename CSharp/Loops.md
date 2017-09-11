# Soorten

We moeten onderscheid maken tussen 2 soorten loops:

- waar we op voorhand weten hoe dikwijls we ze moeten uitvoeren (`for`)
- waar we iets moeten blijven herhalen afhankelijk v.e. voorwaarde (`while`)

> We noemen loops soms ook **iteraties**.



## while-loop

De `while`-loop neemt net zoals een `if` een voorwaarde.

Deze code blijft zichzelf herhalen, zolang `x > 3`:

```cs
int x = 10;
while(x > 3) {
  x--;
  Console.WriteLine(x);
}
```

Deze code zou afkomstig kunnen zijn van een spel om te bepalen wanneer het spel afgelopen is:

```cs
bool gameOver = false;

while(!gameOver) {
  if( DetectCollisions() ) {
    gameOver = true;
  } else {
    UpdateScore();
    MovePlayer();
  }
}

Console.WriteLine("Game over!");
```

Deze code zou afkomstig kunnen zijn v.e. Console-programma
dat afgesloten kan worden door `quit` te typen: 

```cs
string invoer = "";

while(invoer != "quit") {
  Console.Write("Geef een instructie: ");
  invoer = Console.ReadLine();
  
  if(invoer == "help") {
    ToonHelp();
  }
  if(invoer.StartsWith("bereken")) {
    DoCalculation(invoer);
  }
}

Console.WriteLine("Tot ziens!");
```



## for-loop

De `for`-loop gebruik je als op op voorhand weet hoe vaak je moet loopen.

Het is waarschijnlijk de meest gebruikte loop.

Deze code print alle getallen van 0 t.e.m. 10 af:

```cs
for(int i = 0; i < 10; i++) {
  Console.WriteLine(i);
}
```

Er zijn 3 velden die we meegeven in een `for`-loop,
gescheiden door een punt-komma `;`.

- `int i = 0` : we initialiseren een variabele `i` op waarde `0`. Het eerste
veld wordt bij het begin v.d. loop 1 keer uitgevoerd.
- `i < 10` : dit is de voorwaarde die aan het begin van elke loop wordt
gecontroleerd, net zoals bij een `while`-loop
- `i++` : dit verhoogt i met 1. Dit veld wordt op het einde van elke loop
uitgevoerd en wordt typisch gebruikt voor het verhogen v.d. iteratie-variabele.

Je kan bepaalde velden leeglaten maar dit is niet zo mooi.
Deze code is b.v. ook geldig maar sterk af te raden:

```cs
int i = 0;
for(; i < 10;) {
  Console.WriteLine(i);
  i++;
}
```

> In dit laatste voorbeeld is de variabele `i` ook nog buiten (na) de loop
beschikbaar. Het is netter om deze variabele binnen de loop te houden.

Met deze code gaan we de **iteratie-variabele** i na elke stap met 2 verlagen:

```cs
for(int i = 100; i > 0; i -= 2) {
  Console.WriteLine(i);
}
```

Met deze code berekenen we de som van alle getallen van 0 t.e.m. 10:

```cs
int som = 0;
for(int i = 0; i <= 10; i++) {
  som += i;
}
```

Met deze code tekenen we 10 rechthoeken naast elkaar op pixelhoogte 20,
beginnende 10 pixels van de linkerrand v.h. scherm, om de 50 pixels
(verondersteld dat `TekenRechthoek` een `x`- en `y`-parameter neemt):

```cs
for(int i = 0; i < 10; i++ ) {
  TekenRechthoek(10 + 50 * i, 20);
}
```

## Further reading

Algoritmes voor het berekenen van de rij van Fibonacci:

https://en.wikibooks.org/wiki/Algorithm_Implementation/Mathematics/Fibonacci_Number_Program

Merk op:

- **recursief** : m.b.v. een functie die zichzelf aanroept
- **iteratief** : m.b.v. een iteratie dus een for- of een while-loop
