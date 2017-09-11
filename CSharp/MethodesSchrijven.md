# Methodes schrijven

Voor de eenvoud schrijven we een method `Groet()` zonder argumenten en
zonder return-waarde. De **aanroep** ervan is als volgt:

```cs
Groet();
```

De **definitie** ervan als volgt:

```cs
static void Groet() {
  Console.WriteLine("Hallo!");
}
```

> `static` is nodig voor methods die worden aangeroepen vanuit een andere
> static method (b.v. in de `Main`-method van een Console-applicatie.)

## Waar te definiëren?

Waar plaatsen we deze method-definitie?

Methods behoren in C# (bijna) **altijd** tot een class!
Je kan niet zomaar een method *in een andere method* zetten.

Voor een Console-applicatie kunnen we de method-definitie
dus **voor** of **na** de definitie van `Main` zetten:

```cs
class Program {

  static void Groet() {
    Console.WriteLine("Hallo!");
  }

  static void Main() {
    Groet();
  }

}
```
                                                                
Voor een Form-applicatie kunnen we de class `Form1` gebruiken
om de method in te plaatsen:

```cs
partial class Form1 {

  void Groet() {
    Console.WriteLine("Hallo!");
  }

  public Form1() {
    InitializeComponent();
  }
  
  void Form1_Load(Object sender, EventArgs e) {
  
  }
  
  void button1_Click(Object sender, EventArgs e) {
  
  }
  
}
```

Voor een WPF-applicatie kunnen we b.v. de class `MainWindow` gebruiken
om de method in te plaatsen:

```cs
public partial class MainWindow : Window {

  void Groet() {
    Debug.WriteLine("Hallo!");
  }

  public MainWindow()
  {
    InitializeComponent();
  }
  
  private void button_Click(object sender, RoutedEventArgs e)
  {
    if(myWindow == this)
    {
      textBox.Text = "GLEIJK!~";
    }
  }

}
```

## Oefening

### Een method in een Console Applicatie

- Maak een nieuwe Console-applicatie
- Voeg de method `Groet` toe
- Roep de method aan vanuit de `Main`-method
- Zorg dat de method `static` is

> Welke foutmelding krijg je als de `Groet`-method niet `static` is?

### Een method in een WPF Applicatie

- Maak een nieuwe WPF-applicatie
- Zet een `Button` op het main window
- Voeg de method `Groet` toe aan de class `MainWindow`
- Gebruik in de method `Groet` nu `Debug.WriteLine` !
  - Welke namespace moet je toevoegen?
- Roep de method aan vanuit de `Click`-event-handler v.d. `Button`
- Zorg dat de method **niet** `static` is

> Kan je de method ook aanroepen als de `Groet`-method niet `static` is?

Voer de debug-versie uit en open het Output-Window in Visual Studio, zodat je de
output van `Debug.WriteLine(...)` kan zien!

## Further Reading

Wat betekenen deze dingen?

- `static`
- `public`
- `partial`
- `class`
- de `:`

Zie later.

