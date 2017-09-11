# Speciale karakters

Als software-developers komen we allerlei speciale karakters tegen.
Het is handig als we naar deze karakters refereren met hun correcte naam.

[Speciale karakters : naamgeving + ASCII-code](Begrippenlijst/SpecialeKarakters.md)

# CSharp : console

Hoewel we met CSharp ook grafische applicaties (WPF, WinForms) en web-applicaties
(ASP.Net) kunnen maken, hebben console-applicaties zeker nog hun nut en zijn ze
voor een beginnende programmeur vaak het gemakkelijkst om nieuwe concepten in uit
te testen.

Uiteindelijk komt een programma altijd neer op het **verwerken** van een bepaalde
**invoer** en afhankelijk daarvan een bepaalde **uitvoer** terug te geven.

De Console-class biedt dan ook enkel voor de hand liggende methods die we kunnen 
gebruiken om **invoer** en **uitvoer** af te handelen.

- [Console-class : basis](CSharp/Console.md)

> Een knipperende cursor op een console geeft meestal aan dat het programma op 
invoer van de gebruiker wacht.

# CSharp : variabelen

Variabelen zijn een manier om gegevens op te slaan en te benaderen in het RAM-
geheugen. Variabelen hebben altijd een *type*.

CSharp heeft net als bijna elke programmeertaal een aantal *primitieve* types.

- [Variabelen declareren](CSharp/Vars.md)
- [Gehele getallen (`int`)](CSharp/VarsInt.md)
- [Komma-getallen (`double`)](CSharp/VarsDouble.md)
- [Boolean (`bool`)](CSharp/VarsBool.md)
- [Karakters (`char`)](CSharp/VarsChar.md)

Een `string` kan in veel programmeertalen ook beschouwd worden als een *primitief* type
maar we vermelden het hier apart omdat het in CSharp eigenlijk een *sealed class* is.

- [Karakterreeksen (`string`)](CSharp/VarsString.md)

Classes zijn een belangrijk onderdeel van OOP-talen. De objecten die we in WPF
gebruiken zijn een mooi voorbeeld van hoe we **instanties van classes** opslaan in
variabelen. Instanties van classes noemen we **objecten** hoewel dit soms verwarrend is
want instanties van primitieve types worden in CSharp soms ook objecten genoemd.

- [WPF Objecten en constructors](CSharp/WPFObjects.md)

De .NET-library voorziet net als de standaard libraries van andere moderne programmeertalen
in handige types, zoals een `DateTime`. We vermelden `DateTime` en `TimeSpan` apart,
omdat dit in CSharp eigenlijk `struct`'s zijn.

- [`DateTime` en `TimeSpan`](CSharp/DateTime.md)

Daarnaast zijn er mogelijkheden om zelf nieuwe types te maken met `enum`'s, `struct`'s
of `class`'s. Gevorderde programmeurs schrijven zelf extra libraries bovenop de standaard
libraries.

# CSharp : operatoren

Rekenkundige operatoren (`+`, `-`, `*`, `/`, `%`) zijn belangrijk om met numerieke variabelen (getallen)
te werken.

Logische operatoren (`&&`, `||`, `!`) zijn noodzakelijk om met booleaanse variabelen te werken.

Andere veelgebruikte operatoren:

- [Toekenningsoperator](CSharp/Toekenningsoperator.md) 
- [Vergelijkingsoperatoren](CSharp/Vergelijkingsoperatoren.md)

Een vaak gemaakte fout is het verwarren van de toekenningsoperator `=` met de vergelijkingsoperator `==`.

In de meeste programmeertalen is de `+`-operator ook beschikbaar om strings te *concateneren*
(aan elkaar te plakken).

# CSharp: Format strings

Het gebruik van format strings kan het *aan elkaar plakken* van strings aanzienlijk vergemakkelijken.
Je moet dan ook zeker eenvoudige *format strings* kunnen gebruiken.

- [Eenvoudige format strings](CSharp/SimpleFormatStrings.md)

Voor de gevorderde programmeur kan het interessant zijn om te weten dat format strings nog veel meer
mogelijkheden hebben.

- [Geavanceerde format strings en cultuurgebonden instellingen](CSharp/AdvancedFormatStrings.md)

**Opmerking**: Andere programmeertalen zoals C, Python, Go, ... gebruiken een andere syntax maar
kennen meestal wel soortgelijke mogelijkheden. Zie b.v. voor Go: https://gobyexample.com/string-formatting

# CSharp: Methodes

Methodes (ook wel *functies* genoemd) zijn een belangrijke bouwsteen is elke programmeertaal.

> We spreken eigenlijk pas over *methods* als de functies onderdeel zijn van een *class*.
In CSharp zijn alle functies verplicht onderdeel van een class (of een struct) en kunnen we dus
gerust alle functies methods noemen. In andere programmeertalen (b.v. Go waar er eigenlijk geen classes
bestaan) is er een duidelijk verschil tussen functies en methodes.

In de .NET standard library zijn al een heleboel methods gedefinieerd die we kunnen aanroepen.
Sommigen daarvan hebben een *return*-waarde:

- [Methodes aanroepen](CSharp/MethodesAanroepen.md)
- [Methodes : overloads](CSharp/MethodesOverloads.md)

We kunnen ook zelf methods schrijven:

- [Methodes schrijven](CSharp/MethodesSchrijven.md)
- [Parameters toevoegen aan methodes](CSharp/MethodesParameters.md)
- [Overloads van zelf geschreven methods](CSharp/MethodesSchrijvenOverloads.md) 
- [Optionele parameters](CSharp/MethodesOptioneleParameters.md)
- [Methodes met return-waarden schrijven](CSharp/MethodesReturn.md) 

Wanneer we (b.v.) een selectie gebruiken in een method, kunnen we beginnen spreken over
verschillende code-paden:

- [Compiler-fouten : code-paden](CSharp/MethodesCodePaths.md) 
- [Code-paden bij void-methods](CSharp/MethodesVoid.md) 

# Sequentie, selectie en iteratie

Dit zijn **de** 3 basis-constrolestructuren van de meeste programmeertalen.

Met controlestructuren bedoelen we dingen waarmee we het verloop van een programma
kunnen bepalen.

## Sequentie

Een sequentie wil simpelweg zeggen dat elke regel na de vorige wordt uitgevoerd.

Een functie is b.v. een sequentie van opeenvolgende commando's.

Ook andere blokken code (tussen `{` en `}`) kunnen als een sequentie beschouwd worden.

## Selectie (if)

Een selectie maakt een keuze mogelijk.

- [if/then/else](CSharp/IfThenElse.md) 
- [Oefeningen if/then/else](CSharp/IfThenElseOef.md)

Switch/case is alternatieve manier om sommige selecties makkelijker te schrijven.
Het is eigenlijk (https://en.wikipedia.org/wiki/Syntactic_sugar)[syntactic sugar].

- [switch/case](CSharp/SwitchCase.md) 

## iteraties (while/for)

Iteraties maken herhaling mogelijk.

- [`while`- en `for`-loops](CSharp/Loops.md)

# CSharp : datastructuren

Datastructuren zijn een andere belangrijke bouwsteen van programma's.

De meest gebruiksvriendelijke datastructuur in CSharp is waarschijnlijk de `List`.

- [Generieke lijst `List<T>`](CSharp/DatastructList.md)

Datastructuren hebben meestal bijhorende algoritmen, zoals `Sort`.

**Arrays** zijn een andere fundamentele datastructuur.

**Key-Value**-datastructuren (zoals een `Dictionary` in CSharp) maken soms erg
elegante oplossingen mogelijk voor complexe problemen.

Minder vaak voorkomende datastructuren zijn b.v. de `Stack` (met zijn `Push()`
en `Pop()`-methods) of de `Queue`.

Datastructuren worden in een OOP-programmeertaal (zoals CSharp) meestal gedefinieerd
in een aparte class.

# CSharp: Classes

Classes zijn een elementaire bouwsteen van OOP-talen (zoals CSharp, Java, ...).

In CSharp gedragen ook `struct`'s zich soms als (eenvoudige) `class`'s.

De .NET standard library bevat vele classes (en structs) die we kunnen gebruiken
maar je kan natuurlijk ook zelf classes gaan schrijven.

Enkele oefeningen:

- [Oef. hst. 10](CSharp/OefHst10.md)

Een stap-voor-stap-voorbeeld:

- [Tutorial: zelf classes schrijven](CSharp/Classes)

In tegenstelling tot structs, kunnen classes ook van elkaar *overerven*:

- [Tutorial: overerving](CSharp/Overerving)

Vanaf we bekend zijn met het begrip *abstracte class*, kunnen we ook gaan werken
met zogenaamde *interfaces*. Moderne OOP-programma's maken hier veel gebruik van.

- [Interface : introductie](CSharp/InterfacesIntro.md)

# Scope

Lang geleden werden variabelen en functies allemaal gedefinieerd in de
*globale scope*. Dat wil zeggen dat elke variabele en elke functie **overal**
in het programma kon gebruikt worden. Dit leidt vaak tot zeer onoverzichtelijke code.

Daarom willen we steeds de scope van zelf gedefinieerde variabelen en functies
zo klein mogelijk houden, d.w.z. dat ze enkel beschikbaar zijn waar we ze nodig hebben.

- [Scope van lokale en class-variabelen](CSharp/ScopeVars.md)

Omdat programma's tegenwoordig gebruik kunnen maken van zoveel verschillende libraries,
organiseren we verschillende classes in **namespaces**. Dit voorkomt *clashes* (botsingen)
en is ook gewoon ordelijker.

- [Namespaces en `using`](CSharp/Namespaces.md) 

# Random

Het genereren van (pseudo) willekeurige getallen is interessant voor b.v. spelletjes.

- :bangbang: (:hash: 6) [`Random`-class](CSharp/Random.md)

# Code lezen

Men zegt wel eens dat een (professionele) programmeur meer tijd spendeert met code te lezen
dan te schrijven, zeker bij het oplossen van bugs.

Enkele tips:

- [Waarom en hoe code lezen?](CSharp/LezenIntro.md)

Hier wordt enkele korte code-fragmenten zeer uitgebreid en met veel randinformatie verklaard:

- [Lezen van expressies met variabelen](CSharp/LezenVars.md)
- [Lezen van method-aanroepen en -definities](CSharp/LezenMethods.md)

## Voorbeelden van algoritmen

Hier overlopen we zeer uitgebreid enkel probleemstellingen en vergelijken we verschillende
manieren om ze op te lossen.

Er wordt ook aandacht besteed aan **refactoren** : het herschrijven van stukjes code zodat
ze **exact dezelfde functionaliteit** hebben maar wel **duidelijker leesbaar** zijn.

- [Dagen, uren, minuten en seconden omzetten naar seconden](CSharp/Voorbeelden/NaarSeconden.md)
- [Seconden omzetten naar uren, minuten en seconden](CSharp/Voorbeelden/NaarUrenMinutenSeconden.md)
- [Het retour-geld van een drankautomaat berekenen](CSharp/Voorbeelden/Drankautomaat.md)
- [Het spel Hoger/Lager (raad het random getal)](CSharp/Voorbeelden/HogerLager.md)
- [Tijdsmetingen / profilen van algoritmen](CSharp/Voorbeelden/Tijdsmeting.md)
- [Animated GIF omzetten naar ASCII en afbeelden op console](CSharp/Voorbeelden/AnimatedASCIIArt.md)

