# Switch case

Switch/case statements kunnen een lange lijst van 
`if`/`else if`/`else if`/`else` vervangen door een beter leesbare variant.

Er vallen enkele dingen op te merken aan een `switch`/`case`:

- je kan een `default`-case hebben (vergelijkbaar met `else`)
- je kan verschillende cases laten *doorvallen* (zie voorbeeld)
- je kan enkele werken met gelijkheid (`==`) niet met `>`, `<`, ...

Bekijk de volgende oefening ter verduidelijking.

# Oefening

Schrijf de functie `string ScoreNaarWaardering(int score)`.

Schrijf een functie die een score op een toets als parameter meekrijgt en die 
een waardering als string teruggeeft:

- < 5: onvoldoende
- < 7: voldoende
- <= 8: goed
- <= 9: zeer goed
- <= 10: prima

Oplossing: https://dotnetfiddle.net/8Cc8VT
