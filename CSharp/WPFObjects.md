# WPF Objects

Naast de *primitieve* object-types (zoals `int`, `double`, ...) komen we
we nog andere object-types (vaak zogenaamde *classes*) tegen.

## Declaratie

Een rechthoek-object:

```cs
Rectangle rechthoek;
```

Een Ellipse-object:

```cs
Ellipse cirkel;
```

`rechthoek` en `cirkel` zijn dus variabelen, respectievelijk van type `Rectangle` en `Ellipse`.

## Waardes toekennen aan objecten met een constructor

Objecten moeten meestal **geconstrueerd** worden.
Dit doen we met de `new`-operator.

```cs
rect = new Rectangle();
cirkel = new Ellipse();
```

Uiteraard kunnen we declaratie en initialisatie op dezelfde regel doen :

```cs
Rectangle rect = new Rectangle();
Ellipse cirkel = new Ellipse();
```

## Extra voorbeelden

Van een bestaande rechthoek kunnen we de `Margin`-property gelijk stellen aan
een nieuw `Thickness`-object:

```cs
rechthoek.Margin = new Thickness(10, 10, 0, 0);
```

> Je ziet dat de **constructor** ook parameters kan hebben.

## Oef.

Leg volledig en in een duidelijke zin uit wat deze code doet:

```cs
rechthoek.Stroke = new SolidColorBrush(Colors.Black)
```

## Opmerking

WPF objecten kunnen ook gemaakt worden vanuit **XAML**. We moeten dan niet zelf
`new` gebruiken maar dit gebeurt automatisch bij het omzetten van XAML naar
code.

