using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro: MonoBehaviour
{
	[Header( "Uppgift 2" )]
	public string sentence1;
	public string sentence2;
	public string sentence3;

	[Header( "Uppgift 3" )]
	public int number;

	[Header( "Uppgift 4" )]
	public int @base;

	[Header( "Uppgift 5" )]
	public double angle;
	public double peices;

	[Header( "Uppgift 6" )]
	public string Name;

	[Header( "Uppgift 7" )]
	public double radius;

	[Header( "Uppgift 8" )]
	public double minDamage = 100;
	public double maxDamage = 10000;
	public int numDemons = 10;
	public double life = 890000d;

	[Header( "Uppgift 9" )]
	public long count = 1;

	[Header( "Uppgift 10" )]
	public double countMulti = 1d;

	[Header( "Uppgift 11" )]
	public double playerMaxLife;
	[Range( 0, 1 )]
	public double playerResist;
	public double enemyDamage;

	//[Header( "Uppgift 11" )]

	//1. Låt datorn skriva ut svaret (med decimaler) på uträkningen: (963 * 421) - (175463 / 87).

	void Uppgift1()
	{
		double d = ( 963d * 421d ) - ( 175463d / 87d );
		Debug.Log( string.Format( "Härefter skrivs svaret av (963 * 421) - (175463 / 87): {0}", d ) );
	}

	//2. Låt användaren skriva in tre meningar sentence1, sentence2, sentence3, skriv sedan ut dessa tre meningar i ordning. Skapa en funktion för varje mening.
	void Uppgift2_1()
	{
		Debug.Log( sentence1 );
	}

	void Uppgift2_2()
	{
		Debug.Log( sentence2 );
	}

	void Uppgift2_3()
	{
		Debug.Log( sentence3 );
	}

	//3. Låt användaren skriva in ett tal number, skriv sedan ut vad number upphöjt med 2 blir, samt kvadratroten ur number. Använd funktionerna 	Mathf.Pow(a, b) (a upphöjt med b) och Mathf.Sqrt(a) (kvadratroten ur a).
	void Uppgift3()
	{
		float a = Mathf.Pow( number, 2 );
		float b = Mathf.Sqrt( number );
		Debug.Log( string.Format( "{0} uphöjt till 2 är {1}, och kvadratroten ur {0} är {2}", number, a, b ) );
	}

	//4. Räkna ut arean på en triangel med höjden 8, låt användaren bestämma basen base. Skriv ut resultaten i m^2.
	void Uppgift4()
	{
		float höjd = 8;
		float area = ( @base * höjd ) / 2;
		Debug.Log( string.Format( "En triangel med höjden {0} och basen {1} har arean {2}", höjd, @base, area ) );
	}

	double RotToDeg( double rot )
	{
		return ( 360 * rot );
	}

	double DegToRot( double deg )
	{
		return ( deg / 360 );
	}

	// alt + 0176 = °
	//5. Tänk er en cirkelformad tårta, låt användaren skriva in vinkeln angle och låt datorn sedan räkna ut hur många hela bitar man kan skära tårtan i, om varje bit ska ha vinkeln angle. Svaret ska innehålla decimaler.
	//	A. Gör samma som ovan fast tvärtom, dvs låt användaren skriva in ett antal bitar pieces och låt datorn räkna ut vinkeln på bitarna.
	void Uppgift5()
	{
		double numSlices = 1 / DegToRot( angle );
		double angleSlices = RotToDeg( 1 / peices );
		Debug.Log( string.Format( "Om man delar en tårta i delar som alla har vinkeln {1}° så får man {0} delar.\nOm man delar en tårta i {2} delar så är varje del {3}°", numSlices, angle, peices, angleSlices ) );
	}

	//6. Låt användaren skriva in sitt namn name, skriv sedan ut namnet med prefixen (en prefix är en förstavelse framför ordet) “Boss”, och suffixen (suffix är en ändelse efter ordet) “of doom”. Exempel: “Boss {name} of doom”
	void Uppgift6()
	{
		Debug.Log( string.Format( "Boss {0} of Doom", Name ) );
	}

	//7. Låt användaren skriva in en radie radius räkna sedan ut volymen på 2978 klot med radien radius.
	void Uppgift7()
	{
		double volym = System.Math.PI * ( radius * radius * radius * 4 / 3 );
		double totalVolym = volym * 2978;
		Debug.Log( string.Format( "Ett klot med radien {0}u har en volym av {1}u^3, och 2978 klot med den volymen har en total volym på {2}u^3", radius, volym, totalVolym ) );
	}

	//8. Låt användaren skriva in en mängd skada damage. Räkna ut hur många attacker som skadar damage som krävs för att döda en demon med 890000 liv. Svara i heltal.
	//	A. Låt användaren även mata i antalet liv life för demonen
	//	B. Låt användaren mata in antalet demoner.
	//	C. Låt användaren istället för damage mata in minsta skadan minDamage och max skadan maxDamage. Räkna ut hur många attacker som minst behövs, hur många attacker som max behövs, samt hur många attacker i snitt som behövs.
	void Uppgift8()
	{
		int minNumHits = (int) System.Math.Ceiling( life / minDamage ) * numDemons;
		int maxNumHits = (int) System.Math.Ceiling( life / maxDamage ) * numDemons;
		int averageNumHits = ( minNumHits + maxNumHits ) / 2;

		Debug.Log( string.Format( "{0} demoner med {1} liv var tar minst {2} attacker att döda och som mest {3} attacker med ett genomsnitt på {4} attacker", numDemons, life, minNumHits, maxNumHits, averageNumHits ) );

	}

	//Skapa ett värde count, gör så att värdet dubbleras varje frame.Skriv ut resultatet varje frame.

	void Uppgift9()
	{
		Debug.Log( "count är nu: " + count );
		count <<= 1;
	}

	//Skapa ett värde countMulti, multiplicera det med 3 och dela det därefter med 2. Skriv ut värdet.
	void Uppgift10()
	{
		Debug.Log( "countMulti är nu: " + countMulti );
		countMulti = ( countMulti * 3 ) / 2;
	}

	//Skapa 3 variabler, playerMaxLife, playerResist, enemyDamage.
	//Gör så att spelaren tar skadan enemyDamage, men den reduceras med playerResist.
	//Låt playerResist vara ett procentvärde (0 till 1) och multiplicera skadan med det.
	void Uppgift11()
	{
		double playerLife = playerMaxLife - ( enemyDamage * playerResist );
		Debug.Log( string.Format( "Spelaren hade {0} liv. Fienden gjorde {2} damage, varav {4} skyddades mot av spelarens {5} resist. Den effektiva skadan var {3}. Spelaren har nu {1} liv",
			playerMaxLife, playerLife, enemyDamage, enemyDamage * ( playerResist ), enemyDamage * (1 - playerResist ), playerResist ) );
	}



	void Start()
	{
		Uppgift1();
		Uppgift2_1();
		Uppgift2_2();
		Uppgift2_3();
		Uppgift3();
		Uppgift4();
		Uppgift5();
		Uppgift6();
		Uppgift7();
		Uppgift8();
		Uppgift11();
	}


	void Update()
	{
		Uppgift9();
		Uppgift10();
	}
}
