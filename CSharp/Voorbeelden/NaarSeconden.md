# Dagen, uren, minuten en seconden naar totaal aantal seconden

## Analyse

Een aantal dagen, uren, minuten en seconden moet omgezet worden naar een totaal
aantal seconden.

We weten dat:

- een minuut uit `60` seconden bestaat
- een uur uit `60` minuten of `60 * 60 = 3600` seconden bestaat
- een dag uit `24` uur of `24 * 60 * 60` seconden bestaat

## Input- en output-variabelen

We moeten steeds bepalen welke variabelen we nodig hebben, alsook de **naam**
en het **type** ervan.

De **input** bestaat uit 4 **gehele** getallen:

- `aantalDagen`
- `aantalUren`
- `aantalMinuten`
- `aantalSeconden`

De **output** bestaat uit 1 **geheel** getal:

- `totaalAantalSeconden`

Er komen **enkel** gehele getallen in voor. We kiezen dus voor alles type `int`.
Bovendien is een `int` (AKA `Int32`) waarschijnlijk groot genoeg om het grootste
getal (`totaalAantalSeconden`) in op te slaan, tenminste zolang we geen
overdreven grote input-waarden meegeven.

> Voor het gemak gaan we er van uit dat:
> - `aantalUren` nooit groter zal zijn dan 24
> - `aantalMinuten` nooit groter zal zijn dan 60
> - ...

> Dit hangt natuurlijk af van de invoer van de gebruiker en de specifieke
> toepassing. In een stabiel programma zouden de input-variabelen eerst moeten
> gecheckt worden op validiteit.

## Algoritme

Het moet haalbaar zijn om een oplossing te vinden m.b.v. de **rekenkundige
operatoren** omdat we enkel met getallen (en b.v. niet met strings) moeten
werken:

- `+`, `+=`, `++`
- `-`, `-=`, `--`
- `*`, `*=`
- `/`, `/=`
- `%`, `%=`

Als we even verder nadenken, zien we zelfs dat we enkel `+` en `*` zullen nodig
hebben.

Net zoals bij wetenschappelijke formules, kan het helpen om bij elk getal een
**eenheid** te bedenken. De input-variabele `aantalSeconden` heeft dezelfde
eenheid als `totaalAantalSeconden`. We mogen dus dit doen:

```
totaalAantalSeconden += aantalSeconden;
```

Vervolgens kunnen we met `*` de andere variabelen (die als eenheden *minuten*,
*uren* en *dagen* hebben) omzetten naar *seconden*. We kunnen eveneens meteen
deze resultaten optellen bij `totaalAantalSeconden`.

```
totaalAantalSeconden += aantalMinuten * 60;
totaalAantalSeconden += aantalUren * 60 * 60;
totaalAantalSeconden += aantalDagen * 60 * 60 * 24;
```

> Het kan geen kwaad om berekeningen zoals `60 * 60 * 24` in de code te laten
> staan. De compiler zal dit voor ons uitrekenen. Het programma zal er niet
> trager door worden.

## Testen

Uiteraard moet **al** je code steeds getest zijn. Je zal dus minstens het
resultaat moeten tonen, b.v. met

```
Console.WriteLine(totaalAantalSeconden)
```

of je kan alles wat duidelijker maken door ook de input-variabelen te vermelden,
b.v.

```
Console.WriteLine("d: {0} u: {1} m: {2} s: {3} = {4} seconden", 
                                                          aantalDagen, 
                                                          aantalUren,
                                                          aantalMinuten,
                                                          aantalSeconden,
                                                          totaalAantalSeconden);
```

Maar om goed te testen, moet je met verschillende input-waardes testen. Het
makkelijkst is soms om **in de code** de input-variabelen aan te passen en het
programma een aantal keer uit te voeren.

Je kan dus een keertje testen met deze input-waarden: 

```
int aantalDagen = 3;
int aantalUren = 23;
int aantalMinuten = 55;
int aantalSeconden = 45;
```

maar het kan ook interessant zijn om te proberen wat er gebeurt bij onverwachte
input, zoals:

```
int aantalDagen = 3000000;
int aantalUren = 27000;
int aantalMinuten = 400;
int aantalSeconden = 700;
```

Het is waarschijnlijk het beste om met een aantal gemakkelijk te controleren
input-waarden te testen:

```
int aantalDagen = 0;
int aantalUren = 0;
int aantalMinuten = 0;
int aantalSeconden = 3;
```

> Je ziet dat je dit programma al minstens een 5-tal keer moet uitvoeren.
> Bovendien zou je die tests steeds opnieuw moeten uitvoeren als je iets wijzigt
> aan de code. (Er gebeuren soms onverwachte dingen die je over het hoofd kan zien!)
> Daarom wordt dit soort tests vaak geautomatiseerd met **Unit Tests**.

## Afgewerkt programma

Je moet jezelf steeds afvragen hoeveel tijd je wil steken in de afwerking van
een oefening of programma. Je kan bijvoorbeeld in de verleiding komen om een
(zeer) uitgebreide UI te maken. Daar heb je dan misschien enkele extra
variabelen en methods voor nodig. 

Zorg er in elk geval voor dat je steeds de **hoofdzaak** (het algoritme en de
input- en output-variabelen) goed kan onderscheiden van de **bijzaak** (de UI).

Het is meestal een goed idee om:

- eerst en vooral alle benodigde variabelen te declareren en te initialiseren
- bepaalde stukken code van elkaar te scheiden met een witregel

```
string invoer = "";

int aantalDagen = 0;
int aantalUren = 0;
int aantalMinuten = 0;
int aantalSeconden = 0;

int totaalAantalSeconden = 0;

Console.WriteLine("Welkom! We zullen een aantal dagen, uren en minuten omzetten naar seconden.");
Console.Write("Geef het aantal dagen: ");
invoer = Console.ReadLine();
aantalDagen = Convert.ToInt32(invoer);
Console.Write("Geef het aantal uren: ");
invoer = Console.ReadLine();
aantalUren = Convert.ToInt32(invoer);
Console.Write("Geef het aantal minuten: ");
invoer = Console.ReadLine();
aantalMinuten = Convert.ToInt32(invoer);
Console.Write("Geef het aantal seconden: ");
invoer = Console.ReadLine();
aantalSeconden = Convert.ToInt32(aantalSeconden);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("We berekenen het totaal seconden... Even geduld...");
Console.ResetColor();

totaalAantalSeconden += aantalSeconden;
totaalAantalSeconden += aantalMinuten * 60;
totaalAantalSeconden += aantalUren * 60 * 60;
totaalAantalSeconden += aantalDagen * 60 * 60 * 24;

Console.WriteLine("d: {0} u: {1} m: {2} s: {3} = {4} seconden", 
   aantalDagen, 
   aantalUren,
   aantalMinuten,
   aantalSeconden,
   totaalAantalSeconden);
```

> In bovenstaande code zit een bug die je kan vinden door aandachtig de code te
> lezen maar misschien sneller te vinden is door een aantal tests uit te voeren!

## Refactoren

Soms kan je op het einde nog een kleine refactoring doen, zoals het hernoemen
van een variabele. Belangrijk is dat de code goed leesbaar is en logisch in
elkaar zit.

## Gebruik van een method voor het algoritme

Het kan soms veel duidelijker zijn om een algoritme af te zonderen van de rest
van de code, b.v. in een aparte method of class.

Voor dit specifieke algoritme zou een **method** uitermate geschikt zijn:

- de input-variabelen kunnen de **parameters** van de method zijn
- de output-variabele (er is er maar 1) kan de **return-waarde** van de method
  zijn
  
We krijgen dan een method met b.v. volgende signatuur:

```
static int BerekenTotaalAantalSeconden(int dagen, int uren, int minuten, int seconden);
```

De definitie v.d. method kan er dan zo uit zien:

```
static int BerekenTotaalAantalSeconden(int dagen, int uren, int minuten, int seconden) {
  int totaalAantalSeconden = 0;

  totaalAantalSeconden += seconden;
  totaalAantalSeconden += minuten * 60;
  totaalAantalSeconden += uren * 60 * 60;
  totaalAantalSeconden += dagen * 60 * 60 * 24;
  
  return totaalAantalSeconden;
}
```

Helaas maken we daarmee onze (Console)-UI niet compacter (maar misschien wel
duidelijker). We moeten immers nog steeds de user-input opslaan in aparte
variabelen voor we ze aan `BerekenTotaalAantalSeconden` als argumenten kunnen
meegeven. In het geval van een WPF- of Web-applicatie zal deze method echter
handiger zijn en bovendien kunnen we ze makkelijk copy-pasten in nieuwe
programma's zodat we ze **als bouwsteen kunnen blijven gebruiken**.

## Gebruik van hulp-methods

Een andere plaats om te refactoren zou de user-invoer kunnen zijn. We zien dat
we 4 keer een *prompt* tonen aan de gebruiker om een getal terug te vragen.

We herhalen gelijkaardige code 4 keer:

```
Console.Write("Geef het aantal dagen: ");
invoer = Console.ReadLine();
aantalDagen = Convert.ToInt32(invoer);
```

Wat we eigenlijk doen is 4 keer een prompt tonen en een geheel getal vragen. Wat
als we daarvoor een method bedenken?

```
static int VraagGeheelGetal(string prompt);
```

Aan de signatuur van deze method zien we dat er een prompt (`string`) als
parameter wordt meegegeven en een `int` wordt gereturnd.

We kunnen nu dus schrijven:

```
aantalDagen = VraagGeheelGetal("Geef het aantal dagen: ");
aantalUren = VraagGeheelGetal("Geef het aantal uren: ");
aantalMinuten = VraagGeheelGetal("Geef het aantal minuten: ");
aantalSeconden = VraagGeheelGetal("Geef het aantal seconden: ");
```

De implementatie v.d. method kan er dan zo uit zien:

```
static int VraagGeheelGetal(string prompt) {
  string invoer = "";
  int getal = 0;

  Console.Write(prompt);
  invoer = Console.ReadLine();
  getal = Convert.ToInt32(invoer);
  
  return getal;
}
```

Bovendien kunnen we nu veel gemakkelijker aanpassingen doen, zoals:

- de kleur van de prompt wijzigen
- foutafhandeling, b.v. als de gebruiker een letter i.p.v. een getal ingeeft
- ...

## Oefening

Refactor zelf de Console-UI versie van hierboven naar een versie die gebruik
maakt van de methods `BerekenTotaalAantalSeconden` en `VraagGeheelGetal`.

Zie je ook waarom de *bug* uit de eerste versie nu veel minder kans heeft om aan
onze aandacht te ontsnappen?

