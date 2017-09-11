# Namespaces

De DotNet-libraries zijn georganiseerd in **namespace**.

Bovenaan in een source-file wordt telkens met `using` aangeduid welke namespaces
in die source-file beschikbaar zijn.

De belangrijkste namespace is waarschijnlijk `System`:

```cs
using System;
```

Kijk met de *object browser* in Visual Studio welke dingen allemaal in de
`System`-namespace zitten.

## Console-applicaties

Nieuwe Console-projecten (met de VS-wizard gemaakt) gebruiken volgende namespaces:

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
```

## WPF-applicaties

Nieuwe WPF-applicaties (met de VS-wizard gemaakt) gebruiken volgende namespaces:

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
```

## Niet noodzakelijk

`using` is niet noodzakelijk maar wel handig.

```cs
System.Console.WriteLine("Hello");
```

Het is dus korter om dit te doen:

```cs
using System;
```

```cs
Console.WriteLine("Hello");
```

