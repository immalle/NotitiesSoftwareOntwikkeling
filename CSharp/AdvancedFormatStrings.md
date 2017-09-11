# Geavanceerde format-strings

Een format-string kan objecten anders weergeven dan ze werkelijk zijn (vergelijk
dit met de weergave van een cel in Excel (zie
[Excel Cell Formatting](../Excel/CellFormatting.md)):

```cs
Console.WriteLine("Een cirkel met straal {0} heeft {1:0.00} als omtrek en {2:0.00000} als oppervlakte.",
                  straal, omtrek, oppervlakte);
                  
// output:
// Een cirkel met straal 2.3 heeft 14.45 als omtrek en 16.61903 als oppervlakte.
``` 

Of opmaken als een munteenheid (currency):

```cs
Console.WriteLine("Een bedrag van {0} kan ook weergegeven worden als {0:C}.", price);
```

# ToString

De method `ToString` is dankzij *overerving* aanwezig in elk CSharp-object.
In zijn meest eenvoudige vorm converteert het objecten naar een af te printen
string.

```cs
int i = 3;
Console.WriteLine(i.ToString()); // strict genomen niet nodig, want WriteLine kan ook int's afprinten
```

`ToString` aanvaardt ook format-strings : het gedeelte dat bij
`Console.WriteLine` of `String.Format` na de `:` komt.

```cs
Console.WriteLine("{0} is in het hexadecimaal {0:X}.", 15);

string hex = 63.ToString("X");
Console.WriteLine("{0} is in het hexadecimaal {1}.", 63, hex);
```

# Cultuurgebonden

Het afprinten van een munteenheid (net zoals de weergave van datum en tijd) is
verbonden met een cultuur:

```cs
string bedragKronen = 495.95.ToString("C", new CultureInfo("is-IS"));
Console.WriteLine(bedragKronen); // Ijslandse Kronen
string bedragEuro = 495.95.ToString("C", new CultureInfo("nl-BE"));
Console.WriteLine(bedragEuro); // Vlaamse Euro's
```

# Voorbeelden

- https://dotnetfiddle.net/PoyWHr (Oppervlakte en omtrek v.e. cirkel)
- https://dotnetfiddle.net/hVw5r4 (Math-functies)
- https://dotnetfiddle.net/IBDYzc (Advanced format strings en CultureInfo)

# Further reading

- http://www.csharp-examples.net/culture-names/ : C# programma om alle aanwezige
  culturen af te printen
- https://msdn.microsoft.com/en-us/library/26etazsy(v=vs.110).aspx : uitgebreide
  documentatie over alle soorten format strings in .NET
  - https://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx : standaard
    numerieke format strings (`C`, `E`, `P`, `X`, ... )
  - https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx : standaard
    datum en tijd format strings (`d`: korte datun, `D`: lange datum, ...)
  
