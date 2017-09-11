# Gehele getallen

## Declaratie en initialisatie

Declaratie van een geheel getal:

```cs
int x;
```

Declaratie + initialisatie van een geheel getal :

```cs
int x = 3;
```

## Rekenkundige operatoren

Variabelen van type `int` ondersteunen volgende rekenkundige operatoren:

| operator     | omschrijving                          | voorbeeld         |
|--------------|---------------------------------------|-------------------|
| `+`          | som van 2 termen                      | `int a = 2 + 3;`  |
| `-`          | verschil tussen 2 termen              | `int b = 8 - 12;` |
| `*`          | product van 2 factoren                | `int p = 2 * 7;`  |
| `/`          | quotient van 2 deeltal met deler      | `int q = 13 / 3;` |
| `%`          | rest bij (gehele) deling              | `int r = 13 % 3;` |
| prefix `++`  | eerst met 1 verhogen, daarna returnen | `int b = ++a;`    |
| postfix `++` | eerst returnen, daarna met 1 verhogen | `int b = a++;`    |

## Voorbeelden

https://dotnetfiddle.net/Al9h5s : alle rekenkundige operatoren bij `int`'s

## Varianten

Een `int` in C# komt overeen met het .NET type `System.Int32`.

Een greep uit enkele andere types voor gehele getallen:

| C# type | .NET type     | beschrijving       | grootte | kleinst mogelijke waarde | grootste mogelijke waarde |
|---------|---------------|--------------------|---------|--------------------------|---------------------------|
| byte    | System.Byte   | een unsigned byte  | 8 bits  |                        0 |                       255 |
| sbyte   | System.SByte  | een signed byte    | 8 bits  |                     -128 |                       127 |
| ushort  | System.UInt16 | een unsigned short | 16 bits |                        0 |                     65535 |
| short   | System.Int16  |                    | 16 bits |                   -32768 |                     32767 |


## Oefening

Schrijf een programma dat in een mooi uitgelijnde tabel (gebruik liefst
Format-strings) de minimum en maximum waarde van elk type afdrukt.

Voor een overzicht van alle types, zie
https://msdn.microsoft.com/en-us/library/ya5y69ds.aspx
 
Je kan deze code gebruiken:

```cs
string fmt = "{0,20} {1,20} {2,20}";
Console.WriteLine(fmt, "type", "minimum", "maximum");
Console.WriteLine(fmt, "sbyte", sbyte.MinValue, sbyte.MaxValue);
```
 
(Alle basistypes hebben een `MinValue`- en `MaxValue`-property waarmee hun
kleinste (respectievelijk hoogst) mogelijke waarde mee kan opgevraagd worden.)

> OPL: https://dotnetfiddle.net/vO9YWt


