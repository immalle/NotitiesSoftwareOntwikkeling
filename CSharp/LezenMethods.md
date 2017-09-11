# Lezen van method-aanroepen en -definities

## De Program-class en de Main-method

```
class Program {

    public static void Main() {
    
    }

}
```

De class `Program` heeft een method `Main`. De naam `Main` is speciaal : er mag
in elk programma maar 1 method met deze naam zijn. Het is de method die
uitgevoerd wordt als het programma opstart.

De `Main`-method is altijd `static`.


```
class Program {

    public static int Main(string[] args) {
        if(args.Length < 2) {
          return -1;
        }
        return 0;
    }

}
```

Het return-type moet `void` of `int` zijn. Met een `int` kan een programma bij
het afsluiten een foutcode terugsturen naar de shell.

De `Main`-method **mag** een parameter hebben van type `string[] args`. Deze
array bevat de bestandsnaam van de executable in `args[0]` en eventueel de
meegegeven argumenten. (b.v. `mytool -arg1 -arg2 arg3`)

In het voorbeeld zal de `Main`-method `-1` aan de shell returnen als er geen
extra argument werd meegegeven.

## Console.WriteLine

We weten dat `Console.WriteLine()` een lege regel op de console typt (eigenlijk
het symbool `\n` (new line = `LF` = line-feed) of, afhankelijk van het platform
een `\r` of `\n\r` of `\r\n`) (`\r` = `CR` = carriage return, afkomstig van oude
typewriters). Zie ASCII-tabel.

```
Console.WriteLine();
```

Maar wat als we dit niet zouden weten? We zouden de code zo kunnen
interpreteren:

- De code roept de method `WriteLine` aan.
- `WriteLine` wordt hier aangeroepen zonder parameters. Misschien zijn er nog
  andere overloads maar het is dus toegestaan om er geen mee te geven. Misschien
  zijn er *default parameters* gedefinieerd voor deze method.
- Waarschijnlijk heeft de method geen return-waarde en moest dat toch zo zijn, dan
  wordt er hier niets mee gedaan.
- `Console` moet een **class** of een **object** zijn want andere dingen (zoals
  namespaces) kunnen geen methods hebben. We vermoeden dat het een class is
  omdat het met een **hoofdletter** geschreven is.
- `WriteLine` behoort tot de `Console`-class. Het is een *member* van deze
  class.
- Eens we weten dat `Console` een class is, weten we ook dat de method *static*
  is omdat enkel static methods rechtstreeks vanuit een class kunnen worden
  aangeroepen.

We kunnen al deze vermoedens controleren in Visual Studio door over welbepaalde
tekst te *hoveren*. We kunnen de **Object Browser** raadplegen of de *reference
manual* van de DotNet Standard Library consulteren op http://msdn.microsoft.com.
We kunnen zelfs de broncode bekijken op GitHub :
(https://github.com/dotnet/corefx/blob/3d3c8602a484d40c7729659525946b9c97a3a003/src/System.Console/src/System/Console.cs#L512)

## Console.ReadLine

```
string s = Console.ReadLine();
```

- Er wordt een variabele `s` gedeclareerd van type `string`.
- Met de toekenningsoperator wordt er een waarde aan toegekend.
- Die toekenning kan pas gebeuren als de waarde aan de rechterkant van de
  toekenningsoperator gekend is.
- De method `ReadLine` is een `static` method van de class `Console` (zie
  vorige)
- De method `ReadLine` wordt hier aangeroepen zonder parameters.
- De method `ReadLine` returnt een `string`.

## BerekenSom-method

```
public static int BerekenSom(int a, int b) {
    return a + b;
}
```

- De method `BerekenSom` wordt hier gedefinieerd.
- In de *body* v.d. method staat slechts 1 *statement* : `return a + b;`
- De method is `public`, d.w.z. dat ze ook buiten de class waar ze in staat, kan
  gebruikt worden
- De method is `static`, d.w.z. dat we ze kunnen gebruiken zonder dat we een
  object moeten hebben van de class waar ze in staat
- De method returnt een `int`
- De method heeft 2 parameters, beiden `int`.
- De expressie `a + b` zal moeten worden uitgevoerd, vooraleer ze kan gereturned
  worden
  
## WiskunstigeTools-class
 
```
class WiskundigeTools {

    public static int BerekenSom(int a, int b) {
        return a + b;
    }

}
```

We zien dat de method `BerekenSom` tot de class `WiskundigeTools` behoort.
`BerekenSom` is **static** en **public**, dus we kunnen ze zo gebruiken:

```
int som = WiskundigeTools.BerekenSom(3, 2);
```

De argumenten `3` en `2` worden meegeven aan de parameters `a` en `b` van de
method `BerekenSom`.

