# Strings

Een string is een aaneenschakeling van karakters (van type `char`).
De **index-operator** `[]` werkt daarom ook op strings!
(Zie [`char`](VarsChar.md) voor meer informatie.)

Je kan zowel `string` (met kleine letter) als `String` met grote letter 
gebruiken.

## Strings aanmaken

Je kan strings aanmaken zoals andere primitieve types:

```cs
string s = "hallo";
```

Maar je kan ook 1 van de constructors gebruiken, waarvan dit een interessante
is:

```cs
string line = new String('+', 20); // een string van 20 '+'-karakters
```

## De string-concatenatie-operator

Met `+` kunnen we strings *concateneren* of *aan elkaar plakken*.

```cs
string s1 = "Hallo";
string s2 = "wereld";

Console.WriteLine(s1 + " " + s2 + "!");
```

## String en vergelijkingsoperatoren

Je kan enkel de operatoren `==` en `!=` gebruiken.

```cs
string s1 = "hallo";
string s2 = "hello";
bool stringsGelijk = s1 == s2;
```

> Als je zou willen controleren of een string alfabetisch voor of na een andere
string komt, zoek dan b.v. op `CompareTo`. Hou er wel rekening mee dat C#
vele talen en schrijfsystemen ondersteund en dat we soms (b.v. voor filenames
op een Windows-schijf) hoofdletterongevoeligheid prefereren.

> Je kan ook eens kijken naar https://dotnetfiddle.net/0tzCxh


## Speciale karakters

De double quote (`"`) staat aan het begin en einde van een string.
Hoe kan je het karakter `"` toch in een string steken?

Je moet het karakter dan *escapen* door er `\` voor te zetten, b.v.

```cs
string escaping = "Een dubbele quote (\") en een single quote (')";
```

Maar hoe kan je dan een `\` in een string zetten?

- Ofwel escape je `\` zelf. Dat wordt dan `"\\"`
- Ofwel zet je een `@` voor de ganse string

```cs
string escapingBackSlash1 = "Een slash (/) en een back-slash (\\)";
string escapingBackSlash2 = @"Een slash (/) en een back-slash (\)";
string filePath1 = "C:\\This\\Windows\\Path\\Uses\\Backslashes\\";
string filePath2 = @"C:\This\Windows\Path\Uses\Backslashes\";
```

## String-properties en -methods

- `.Length` : returnt de lengte van de string
- `.ToLower` : returnt een string met enkel kleine letters
- `.ToUpper` : return een string met enkel hoofdletters
- ...

## De lege string

Dit code-fragment toont aan dat `""` en `String.Empty` synoniemen zijn:

```cs
string leeg1 = "";
string leeg2 = string.Empty;
if(leeg1 == leeg2) Console.WriteLine("\"\" == string.Empty");
```

## De ToString-method

Omdat een string een veel gebruikte voorstelling is die voor ons (mensen)
goed leesbaar is, hebben vele objecten hebben een `.ToString()`-method:

```cs
int i = 3;
string s = i.ToString();
```

> Als we zelf classes gaan maken, kunnen we ook de `.ToString()`-method
voor onze eigen classes implementeren.

## Achtergrondinformatie

### Sealed

`string` is eigenlijk een **sealed class**.
Dat wil zeggen dat we er niet van kunnen overerven.

M.b.v. *extension methods* kunnen we eventueel wel extra methods toevoegen aan
de `string`-class.

### Immutable en het nut van StringBuilder

Strings zijn *immutable*.
Dat wil zeggen dat een string die in het geheugen zit, niet meer kan aangepast
worden. We kunnen wel een aangepaste kopie van de string maken.

> Dit verklaart ook gedeeltelijk waarom b.v. de `.ToUpper()`-method niet de
string zelf zal aanpassen maar wel een aangepaste kopie zal returnen. B.v.

```cs
string s = "hallo wereld";
s.ToUpper(); // s is nog steeds in kleine letters
s = s.ToUpper(); // s is nu overschreven door een nieuwe string "HALLO WERELD"
```

Het is performanter om te werken met de `StringBuilder`-class als je
zo snel mogelijk veel wijzigingen moet maken in (lange) strings. Zoniet, zul
je dus veel RAM-geheugen gebruiken omdat er voor elke wijziging een nieuwe
string moet gemaakt worden.

Deze code zal b.v. een string maken bestaande uit 1000 `a`'s maar zal daardoor
ook 1000 strings (tijdelijk) aangemaakt hebben in het RAM-geheugen.

```cs
string s = "";
for(var i=0; i<1000; i++) s += "a";
```

Deze code gaat efficienter met het RAM-geheugen om:

```cs
var sb = new StringBuilder();
for(var i=0; i<1000; i++) sb.Append("a");

string s = sb.ToString();
```

## Voorbeelden

https://dotnetfiddle.net/blPRGu

