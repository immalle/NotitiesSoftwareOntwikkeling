# Drankautomaat

## Analyse

Een drankautomaat moet *gepast* geld terug geven.

Het terug te geven bedrag is simpelweg `retour = inworp - kostprijs`. De
moeilijkheid is `retour` te verdelen in zo weinig mogelijk muntstukken. Dit kan
door:

- eerst zoveel mogelijk v.d. grootste muntstukken terug te geven (2 euro)
- vervolgens zoveel mogelijk v.d. tweede grootste (1 euro)
- enz ...

We moeten dus controleren hoeveel van de grootste muntstukken er in `retour`
passen. Hetgeen overblijft moet opnieuw in zo groot mogelijke muntstukken worden
verdeeld.

## Input- en output-variabelen

We moeten steeds bepalen welke variabelen we nodig hebben, alsook de **naam**
en het **type** ervan.

De **input** noemen we `retour`, een bedrag in Euro.

Voor de **output** hebben we 8 variabelen nodig:

- `aantal2Euro`
- `aantal1Euro`
- `aantal50Cent`
- `aantal20Cent`
- `aantal10Cent`
- `aantal5Cent`
- `aantal2Cent`
- `aantal1Cent`

Welk type geven we deze variabelen?

De meest voor de hand liggende keuze is `double` voor `retour` omdat een
**geldbedrag in Euro** een **komma-getal** is. Voor elke `aantal`-variabele
lijkt `int` het meest logisch omdat een **aantal muntstukken** steeds uit te
drukken is in een **geheel aantal**.

Wanneer je met variabelen van verschillende types werkt (b.v. `double` en
`int`), moet je altijd rekening houden met **conversies** en alle mogelijke
gevolgen (zoals afrondingsfouten). Indien mogelijk, vermijden we dit liever!

In dit geval kunnen we dit (eventueel) vermijden door het programme te laten
rekenen in **eurocenten**. 1 Euro wordt dan voorgesteld als 100 cent.
We werken nu dus met **enkel `int`'s**!

We kiezen de variabelen:

```
int retour = 0;

int Aantal2Euro = 0;
int Aantal1Euro = 0;
int Aantal50Cent = 0;
int Aantal20Cent = 0;
int Aantal10Cent = 0;
int Aantal5Cent = 0;
int Aantal2Cent = 0;
int Aantal1Cent = 0;
```

## Het algoritme

### Enkele concrete voorbeelden

Hoe beginnen we na te denken hoe we dit probleem kunnen oplossen? Mensen die
goed algoritmes kunnen bedenken, zijn vaak goed in *abstraheren* : van het
*concrete* naar het *abstracte*. Voor de meeste mensen is het gemakkelijker om
te beginnen met enkele concrete voorbeelden.

Voorbeeld 1:

- we werpen `2.50` euro in
- de kostprijs is `2.10`
- we moeten dus in totaal `0.40` teruggeven
- de grootst mogelijke munten zijn dus 2 munten van 20 cent

Voorbeeld 2:

- we werpen `2.00` euro in
- de kostprijs is `0.43` (om het interessant te maken)
- we moeten dus in totaal `1.57` teruggeven
- op welke manier kunnen we `1.57` het best omzetten in zo groot mogelijke
  muntstukken?
  
We komen stilaan tot een (altijd werkend) algoritme als we een strict te volgen
stappenplan kunnen opstellen.

Hoeveel moeten we van elk stuk teruggeven? De meeste mensen zullen bij het
zoeken naar muntstukken voor een bedrag als `1.57` beginnen bij de grootste
muntstukken: 

- `aantal2Euro` : `0`
- `aantal1Euro` : `1`
- `aantal50Cent` : `1`
- `aantal20Cent` : `0`
- `aantal10Cent` : `0`
- `aantal5Cent` : `1`
- `aantal2Cent` : `1`
- `aantal1Cent` : `0`

> Sommige kassiers werken omgekeerd: ze vertrekken van de `kostprijs` en tellen
> muntstukken bij, tot ze aan de `inworp` zijn aanbeland.

### Een oplossing met een while-loop

Je kan in de verleiding komen om een oplossing te zoeken m.b.v. de meest
voorkomende controle-structuren zoals `if/else`, `while`, `for`, ...

Laten we dat even proberen...

We zullen in een variabele moeten bijhouden hoeveel geld we al terug hebben
gegeven. We kunnen hiervoor gerust de variabele `retour` gebruiken. Laten we dus
telkens de reeds getelde muntstukken aftrekken van `retour`.

```
if(retour > 200) {
    aantal2Euro += 1;
    retour -= 100;
}
```

Als we nu voldoende `else if` statements schrijven voor elk muntstuk en dit
blijven herhalen in een while-loop tot `retour == 0`, komen we bij de oplossing:

```
while(retour > 0) {
    Console.WriteLine(retour);
    if(retour >= 200) {
        retour -= 200;
        aantal2Euro += 1;
    } else if(retour >= 100) {
        retour -= 100;
        aantal1Euro += 1;	
    } else if(retour >= 50) {
        retour -= 50;
        aantal50Cent += 1;	
    } else if(retour >= 20) {
        retour -= 20;
        aantal20Cent += 1;	
    } else if(retour >= 10) {
        retour -= 10;
        aantal10Cent += 1;	
    } else if(retour >= 5) {
        retour -= 5;
        aantal5Cent += 1;	
    } else if(retour >= 2) {
        retour -= 2;
        aantal2Cent += 1;
    } else {
        retour -= 1;
        aantal1Cent += 1;
    }
}
```

> Het voordeel van deze oplossing is dat even goed gebruik kon worden gemaakt
> van `double retour` i.p.v. `int retour`.

### Een oplossing met enkel rekenkundige operatoren

Maar hebben we `if/else` en `while` wel echt nodig? Soms wordt de kracht van
minder bekende operatoren zoals `%` (rest bij gehele deling) uit het oog
verloren. Vergeet ook niet dat we over zoiets beschikken als een **gehele
deling** zodat we ons niet moeten bezighouden met lastigheden zoals afronden.
(Dit is ook dankzij het feit dat we enkel `int`'s gebruiken).

Met een puur rekenkundige tactiek, komen we eigenlijk veel sneller tot een
oplossing:

```
aantal2Euro = retour / 200;  // 480 / 200 = 2
retour = retour % 200;       // 480 % 200 = 80
```

Probeer het even uit met getallen: als we 4.8 euro retour moeten geven. Dat zijn
`2` 2-Euro muntstukken, `1` 50-cent muntstuk en `1` 20-cent muntstuk. `480 / 200` is
inderdaad `2` en `480 % 200` is `80`. Die `80` moeten we dan nog verder verdelen.

```
aantal1Euro = retour / 100;  // 80 / 100 = 0
retour %= 100;               // 80 % 100 = 80
```

> We kunnen ook `%=` gebruiken i.p.v. `%`.

```
aantal50Cent = retour / 50   // 80 / 50 = 1
retour %= 50;                // 80 % 50 = 30
```

En zo verder...

Vergeleken met het vorige algoritme, hebben we nu met 1 berekening meteen het
juiste aantal 2-Euro-muntstukken (`2`), terwijl we dit met de `while`-loop pas
hadden na de tweede iteratie.

We zouden kunnen gaan analyseren welk van de 2 algoritmes nu eigenlijk het
snelste is maar in werkelijkheid is dit zo'n simpel algoritme dat dat er niet
echt toe doet. De leesbaarheid van de code is veel belangrijker. Vind je ook
niet dat in de versie met de `while`-loop je veel meer kans hebt op een bug?


## Het algoritme refactoren naar een method

:construction:

Omdat methods in C# maar 1 variabele als return-waarde kunnen hebben, is een
method op het eerste zicht niet zo geschikt voor dit algoritme.

We zullen hiervoor dan ook bij voorkeur een `struct` of een `class` nodig hebben.

```
struct GeldBedrag {
  int Aantal2Euro;
  int Aantal1Euro;
  int Aantal50Cent;
  int Aantal20Cent;
  int Aantal10Cent;
  int Aantal5Cent;
  int Aantal2Cent;
  int Aantal1Cent;
}
```

De method `BerekenRetour` returnt dan een variabele van het type `GeldBedrag`:

```
static GeldBedrag BerekenRetour(double kostprijs, double inworp);
```

## Uitbreiding: niet voldoende muntstukken

Wat als de drankautomaat niet genoeg van een bepaald muntstuk heeft?
Moeten we het algoritme dan aanpassen of kunnen we het bestaande algoritme
behouden en er een nieuw stuk aan toevoegen? Wat is het beste en met welke
criteria bepaal je dat?

> TIP: de critera hangen sterk af van allerlei factoren zoals:
> - de capaciteiten van de (misschien beperkte) hardware
> - hoe makkelijk de software in de drankautomaat te updaten is
> - hoeveel budget er is om te testen
> - ...

## Demo

https://dotnetfiddle.net/rW6zeC

