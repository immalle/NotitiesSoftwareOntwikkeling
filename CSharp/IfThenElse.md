# Selectie

Een basis-programmeerstructuur is de **selectie**:
op basis v.e. voorwaarde slaat het programma een *andere weg* in.

Er zijn vaak meerdere mogelijke wegen ("code paths").

> Bij het testen v.e. programma moeten eigenlijk alle *code paths* uitgetest
zijn vooraleer je zeker kan zijn dat er geen run-time fouten zullen optreden.



## if-else

```cs
if(x > 3) {

} else {

}
```



## if-elseif-else

Je kan zo veel `else if`'s toevoegen als je wil:

```cs
if(x > 3) {

} else if( x < 21) {

} else if( x < 80) {

}
```

> Denk eraan dat de tests steeds sequentieel (van boven naar onder) doorlopen
> worden. Denk zelf na hoe dat in bovenstaand voorbeeld misschien anders
> uitdraaid dan je op het eerste zicht zou denken.


## switch/case

Als je zeer veel `else if`'s nodig hebt, kan het handiger zijn een
`switch` te gebruiken.


