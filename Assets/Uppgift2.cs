using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift2 : MonoBehaviour {

	float userValue;


	//Övningsnivå
	//Låt användaren bestämma ett värde userValue. Vid knapptryck så ska detta värdet modifieras på följande sätt:
	//När användaren trycker på vänster-pil så ska värdet ökas med 2.
	//När användaren trycker på höger-pil så ska värdet halveras.
	//När användaren trycker på upp-pil så ska det nuvarande värdet skrivas ut. 
	void DoGameOne()
	{
		if ( Input.GetKeyDown( KeyCode.LeftArrow ) )
		{
			
		}
	}

	//Skapa en tärnings-kastar-simulator som räknar poäng.
	//När användaren trycker R så ska två tärningar slås ska den ena lägga till poäng och den andra dra bort poäng.
	//Låt simulatorn starta på 10 poäng.
	//Om poängen blir 20 eller mer så vinner man.
	//Om poängen blir 0 eller lägre så förlorar man.

	//Skapa ett minispel där man ska slåss mot en drake och försöka överleva.
	//Draken ska ha mellan 100-150 liv och det ska randomiseras varje gång spelet startas.
	//Spelaren ska ha 100 liv .
	//När man trycker på Space så ska draken ha 50% chans att träffa ett slag som gör mellan 10 och 20 skada. Samtidigt så ska spelaren slå ett slag som gör mellan 5 och 25 skada, detta slaget ska alltid träffa.
	//När antingen spelaren eller draken dör så ska det stå vem som vunnit.
	//Vidareutveckla uppgift 3.
	//Gör så att det finns en 10% chans att man möter två drakar istället.
	//Randomiseras hur mycket min och max skada spelaren kan göra.
	//Gör så att det finns en 5% chans att spelaren får en crit och direkt dödar draken och därmed vinner.
	

	void Start () {
		
	}
	
	void Update () {
		
	}
}
