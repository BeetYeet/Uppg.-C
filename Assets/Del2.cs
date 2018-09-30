using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Del2: MonoBehaviour
{

	/*
	 * ==  a equals b
	 * !=  a doesn't equal b
	 * <   a less than b
	 * >   a greater than b
	 * <=  a less than or equal to b
	 * >=  a greater than or equal to b
	 * 
	 * Boolean:
	 * && and
	 * || or
	 * 
	 */


	private double userValue;
	private int points;
	private bool diceGameEnded;
	private int dragonHealth;
	private int playerLife;
	private bool dragonGameEnded;
	private int playerMinDamage;
	private int playerMaxDamage;
	private int value;
	private int lastValue;
	private int numWins;
	const string playerPrefName = "HighScoreGuess";

	void Start()
	{
		Reset();
	}

	public void Reset()
	{
		userValue = 0;
		points = 10;
		diceGameEnded = false;
		dragonHealth = Random.Range( 100, 150 ) * (int) ( 1 + ( Mathf.Floor( Random.Range( 1, 10 ) / 10 ) ) );
		playerLife = 100;
		dragonGameEnded = false;
		playerMinDamage = Random.Range(2, 10);
		playerMaxDamage = Random.Range(20, 35);
		value = 50;
		numWins = 0;
		Debug.Log( "All progress was reset! (excluding highscores)" );
	}

	void Update()
	{
		//reset
		if ( Input.GetKeyDown( KeyCode.Return ) )
		{
			Reset();
		}


		// uppg 1
		if ( Input.GetKeyDown( KeyCode.LeftArrow ) )
		{
			userValue += 2;
		}
		if ( Input.GetKeyDown( KeyCode.RightArrow ) )
		{
			userValue /= 2;
		}
		if ( Input.GetKeyDown( KeyCode.UpArrow ) )
		{
			Debug.Log( "userValue is now: " + userValue );
		}


		// uppg 2
		if ( !diceGameEnded && Input.GetKeyDown( KeyCode.R ) )
		{
			int dice1 = Random.Range( 1, 7 );
			int dice2 = Random.Range( 1, 7 );

			Debug.Log( "You rolled a " + dice1 + " and " + dice2 + "!" );
			points += dice1 - dice2;
			if ( points >= 20 )
			{
				Debug.Log( "You Won!" );
				diceGameEnded = true;
			}
			else if ( points <= 0 )
			{
				Debug.Log( "You Lost... :(" );
				diceGameEnded = true;
			}
			else
			{
				Debug.Log( "Your score is now: " + points );
			}
		}


		// uppg 3
		if ( !dragonGameEnded && Input.GetKeyDown( KeyCode.Space ) )
		{

			if ( Random.Range( 0, 20 ) == 19 )
			{
				Debug.Log( "Du Crittar draken och dödar den direkt" );
				Debug.Log( "You Won!" );
				dragonGameEnded = true;
			}
			else
			{
				if ( Random.Range( 0, 2 ) == 1 )
				{
					//dragon hits
					int damage = Random.Range( 10, 20 );
					playerLife -= damage;
					Debug.Log( "Draken träffade spelaren för " + damage + " damage. Spelaren har nu " + playerLife + " liv" );
				}
				else
				{
					//dragon misses
					Debug.Log( "Draken missade sin attack" );
				}
				if ( true ) // so it doesn't complain about damage being in 2 places
				{
					//player hits
					int damage = Random.Range( playerMinDamage, playerMaxDamage );
					dragonHealth -= damage;
					Debug.Log( "Spelaren träffade draken för " + damage + " damage. Draken har nu " + dragonHealth + " liv" );

					if ( dragonHealth <= 0 )
					{
						Debug.Log( "You Won!" );
						dragonGameEnded = true;
					}
					if ( playerLife <= 0 )
					{
						Debug.Log( "You lost... :(" );
						dragonGameEnded = true;
					}
				}
			}
		}


		// uppg 5
		if ( Input.GetKeyDown( KeyCode.Y ) )
		{
			value = Random.Range( 0, 100 );
			if ( value > lastValue )
			{
				//player won
				Debug.Log( "You Won!" );
				numWins++;
				NewWin(numWins);
			}
			else
			{
				//player lost
				Debug.Log( "You lost... :(" );
				numWins = 0;
			}
			lastValue = value;
			Debug.Log( "Your Score is: " + numWins );
			Debug.Log( "Your Highscore is: " + PlayerPrefs.GetInt( playerPrefName ) );
		}
		if ( Input.GetKeyDown( KeyCode.H ) )
		{
			value = Random.Range( 0, 100 );
			if ( value < lastValue )
			{
				//player won
				Debug.Log( "You Won!" );
				numWins++;
				NewWin( numWins );
			}
			else
			{
				//player lost
				Debug.Log( "You lost... :(" );
				numWins = 0;
			}
			lastValue = value;
			Debug.Log( "Your Score is: " + numWins );
			Debug.Log( "Your Highscore is: " + PlayerPrefs.GetInt( playerPrefName ) );
		}

	}


	void NewWin(int guesses)
	{
		if ( PlayerPrefs.HasKey( playerPrefName) )
		{
			int old = PlayerPrefs.GetInt( playerPrefName );
			if ( old < guesses )
			{
				PlayerPrefs.SetInt( playerPrefName, guesses );
			}
		}
		else
		{
			PlayerPrefs.SetInt( playerPrefName, guesses );
		}

	}

}
