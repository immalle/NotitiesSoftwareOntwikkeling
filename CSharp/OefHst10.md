# Oef. classes

  
## 10.5 Dobbelsteen
  
Schrijf een class `Dobbelsteen` :

- met een method `void Werp()` die de waarde van de dobbelsteen at random veranderd
- met een property `int Waarde` waarmee de huidige waarde kan uitgelezen worden
- gebruik best een `static Random`-variabele binnen deze class om te vermijden
  dat er veel verschillende `Random`-objecten gemaakt moeten worden
  
## 10.4 Puntenteller

Schrijf een class `Puntenteller` :

- met een method `Reset()` om op 0 te zetten
- met een method `Verhoog()` om de punten met 1 te verhogen
- met een method `Verlaag()` om de punten met 1 te verlagen
- een property `int Score` om de huidige score te verkrijgen

EXTRA:

Schrijf een dobbelspel met b.v. 2 spelers en 1 dobbelsteen.
Diegene die de hoogste waarde dobbelt (som v.d. 2 dobbelstenen), scoort een punt.
De punten worden opgeslagen in de Puntentellers.


## 10.2

*Display van een versterker*

- Gebruik een slider om het geluidsniveau van een audiosignaal te simuleren
- Schrijf een klasse die minimum en maximum geluidsniveau onthoudt

```cs
class MinMaxGeheugen {

	// TODO

	public void RegistreerHuidigeWaarde(int waarde) {
		// TODO
		// deze method roep je aan telkens als de slider van waarde wijzigt
		
	}
	
	public void Reset() {
		// TODO
		// De onthouden min. en max. waarde terug op 0 zetten.
	}

	public int KleinsteWaarde {
		get {
			// TODO
		}
	}
	
	public int GrootsteWaarde {
		get {
			// TODO
		}
	}
}
```


Uitbreiding:

- Maak een class `MinMaxGeheugen` waarvan de constructor een tijd in milliseconden meekrijgt
  die aanduidt hoe lang het geheugen de min. en max. waarde bewaard


# 10.9

Meerdere vensters in een WPF-applicatie

# 10.8

- `Beep.Play()`
- probeer ook de `SpeechSynthesizer-class v.d. `System.Speech.Synthesis`-namespace
  (hiervoor zal je een Reference moeten toevoegen)