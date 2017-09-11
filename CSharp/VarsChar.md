# Karakters

Een karakter heeft het type `char` en wordt voorgesteld tussen
single quotes (`'`).

```cs
char x = 'x';
char a = 'a';
```

## ASCII en Unicode

Voor een computer worden karakters gewoon voorgesteld door getallen.
Van oudsher wordt hiervoor de ASCII-tabel gebruikt.
Tegenwoordig gebruiken we de Unicode-tabel.

De `UTF-8`-Unicode-codering is *backwards compatible* met de `ASCII`-tabel.

Zie https://nl.wikipedia.org/wiki/ASCII_(tekenset)

> We gebruiken soms liever de **hexadecimale** voorstelling.
> Dit kan in C# met het prefix `0x`.
> Een getal weergeven als hexadecimaal kan met de juiste format-string.

```cs
int a = 0x3;
int b = 0xa; // 0xA = 10
Console.WriteLine(a + b); // resultaat in decimaal
Console.WriteLine("{0:X}"); // resultaat in hexadecimaal
```

## Relatie met strings

Strings kan beschouwen als een soort *array* van `char`'s.
(Zie ook [Strings](VarsString.md).)

We kunnen daarom ook de **index-operator** gebruiken:

```cs
string str = "Hallo!";

char a = str[0];
char b = str[1];
char c = str[2];
char z = str[str.Length-1];
```

En we kunnen er dus ook over itereren:

```cs
for(var i = 0; i < str.Length; i++) {
	Console.WriteLine(str[i]);
}

foreach(var karakter in str) {
	Console.WriteLine(karakter);
}
```

## Voorbeeld

https://dotnetfiddle.net/6QqPMP


