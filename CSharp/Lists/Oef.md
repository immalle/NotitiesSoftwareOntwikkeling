# Trolnamen

Schrijf een method `string GenerateTrolNaam()` die een naam voor trol genereert.

De naam bestaat uit 3 letters:

- eerst een medeklinker
- daarna een klinker
- tot slot nog een medeklinker

Maak hiervoor gebruik van 2 lijsten:

```
var medeklinkers = new List<string>();
var klinkers = new List<string>();
```

Voeg vervolgens telkens met `Add(...)` enkele medekliners en klinkers toe aan
de lijst.

Met een Random-generator kan je 3 keer een random **index** berekenen, waarmee
je dus random letters selecteert en ze toevoegt aan een string. Deze string
return je uiteindelijk.
