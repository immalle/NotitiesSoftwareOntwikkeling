# Toekenningsoperator

De toekenningsoperator `=` kent een waarde toe aan een variabele.

```cs
int x = 3;
x = 4;
x = 4 + 3;

string s = "34";
x = Convert.ToInt32(s);
```

De compiler moet de waarde mogelijk eerst berekenen
voordat de eigenlijk toekenning kan gebeuren.

In dit voorbeeld moet eerst `4 + 3` berekend worden:

```cs
x = 4 + 3
```

Hier moet eerst de functie `Console.ReadLine()` aangeroepen
worden, die pas een waarde returnt als de gebruiker op enter drukt:

```cs
string invoer;

invoer = Console.ReadLine();
```

Ook in dit voorbeeld, moet de `ToInt32`-converter-functie eerst
worden aangeroepen:

```cs
x = Convert.ToInt32(s);
```

## Denkoefening

Aan wat is `x` gelijk in het vorige voorbeeld?

