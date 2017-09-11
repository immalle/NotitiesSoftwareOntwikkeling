# Base

Net zoals we `this` hebben (Zie [This](../Classes/04_This.md)), 
is er ook `base`.

Met `base` kunnen we onderscheid maken tussen variabelen of methods
van de eigen class en die van de moeder-/basisclass.

```
class Dier {
  protected double gewicht;
}

class Paard : Dier {
  void GokGewicht(double gewicht) {
    if(gewicht > base.gewicht) {
      Console.WriteLine("Je gokte te hoog...");
    }
  }
}
```

> We gebruik hier ook de 3e access specifier (naast `public` en `private`):
**protected**. Dit wil zeggen dat deze variabele/method enkel toegankelijk is
voor overervende classes.
