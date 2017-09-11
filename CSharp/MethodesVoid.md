# Code-paden bij void-methods

Void-methods zijn niet verplicht het woord `return` te gebruiken maar het
**mag** wel.

In `OnlyPrintForAdults` wordt een ander code-pad gevolgd als `age` kleiner is
dan `18`. Enkel als de leeftijd groter is dan `18` wordt er op de console
geprint.

```cs
static void OnlyPrintForAdults(int age) {
  if(age < 18) {
    return;
  }
  Console.WriteLine("You are legally an adult!");
}
```

> Op de laatste regel van deze method **mag** `return` staan maar het moet niet!

# Oefening

Schrijf de volgende method:

```cs
static void PrintHelloTwice() {
    Console.WriteLine("Hello");
    return;
    Console.WriteLine("Hello");
}
```

> Compileert deze code? Welke meldingen krijg je te zien?

