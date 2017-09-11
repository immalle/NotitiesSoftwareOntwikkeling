# Lezen van expressies met variabelen

```
int x;
```

Een variabele met de naam `x` wordt gedeclareerd. Er wordt dus geheugenruimte
voorzien om een `int` in op te slaan. `int` is een alias voor `Int32`. Er wordt
dus 32 bit (4 bytes) gereserveerd. Deze geheugenruimte wordt gevlagd als zijnde
een `Int32` wat wil zeggen dat er een positief of negatief getal in te vinden
is. Er bestaat `uint` A.K.A. `UInt32` of *unsigned int* waarin enkel positieve
getallen dus met een postief teken (`+`-sign) in kunnen.

Dat is binair (of hexadecimaal) het eenvoudigst uit te leggen: `0` wordt
voorgesteld door `0x 0000 0000`, het hoogste mogelijk getal door `0x FFFF FFFF`
en b.v. `10` door `0x 0000 000A`.

Hoe wordt dan een negatief getal opgeslagen in een `Int32`? Dat is
platformafhankelijk (b.v. op een ARM- of Intel-processor) maar meestal
gebruikt men de 2-complements-codering. Het punt is dat er evenveel ruimte wordt
gebruikt voor `int` dan voor `uint` en dat bijgevolg de mogelijk waarden anders
zijn. Zie https://dotnetfiddle.net/vO9YWt voor een demo.

```
int x = 3;
```

De toekenningsoperator kent `3` toe aan `x` nadat `x` gedeclareerd is.
Omdat dit samen met de declaratie op 1 regel gebeurt, zeggen we dat `x` wordt
geinitialiseerd.

```
x = -4;
```

Aan de variabele `x` wordt de waarde `-4` toegekend.
Wat het precieze type van `x` is kan met een IDE bepaald worden (b.v. door er
over te hoveren) of in een interactieve prompt met `x.GetType()` opgevraagd
worden.

Vermoedelijk gaat het hier om een geheel getal dat ook negatief kan zijn, een
`int` dus.

```
y = 0xFFFFFFFF;
```

Het hexadecimale getal `0x FFFF FFFF` wordt toegekend aan `y`. Dit is een 32-bit
getal met alle bits op 1 en dus bestaande uit 4 bytes, oftewel 8 nibbles. Het is
de grootste mogelijke waarde die een `UInt32` kan aannemen.

We moeten hieruit concluderen dat `y` een `UInt32` of een `UInt64` is. Tenminste
als we er vanuit gaan dat de code compileert.

