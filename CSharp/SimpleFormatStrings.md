# Format strings

Er zijn een aantal plekken waar je format strings kan gebruiken:

- `Console.WriteLine(...)` : een veel gebruikte manier om output op de console
  te tonen.
- `String.Format(...)` : de static `Format`-method van de `String`-class die de
  geformatteerde string returnt
- `.ToString(...)` : de ToString-method die alle objecten hebben
  
# Eenvoudige format-strings

Een format-string kan het aanmaken van strings beter leesbaar maken.

```cs
Console.WriteLine("Een cirkel met straal {0} heeft {1} als omtrek en {2} als oppervlakte.",
                  straal, omtrek, oppervlakte);
```

Vergelijk met een versie die de **string-concatenatie-operator `+`** gebruikt:


```cs
Console.WriteLine("Een cirkel met straal " + straal + 
                  " heeft " + omtrek + " als omtrek en " + 
                  oppervlakte + " als oppervlakte.");
```

# Wanneer String.Format gebruiken?

`Console.WriteLine` ondersteunt format strings maar b.v. `MessageBox.Show` niet.
In die gevallen (of als je gewoon een format-string wil omzetten naar een gewone
string) gebruik je `String.Format` (de static `Format`-method van de
`String`-class).

```cs
string s = String.Format("{0} + {1} = {2}", 2, 3, 2+3);
MessageBox.Show(s);
```

# Voorbeelden + oefeningen simpele format-strings

- https://dotnetfiddle.net/bUSimf
- https://dotnetfiddle.net/hVw5r4 (Math-functies)

# Further reading

[Geavanceerde format strings en cultuurgebonden instellingen](AdvancedFormatStrings.md)
