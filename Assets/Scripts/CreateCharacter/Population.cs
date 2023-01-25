using PlayableCharacters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
	public Enemy(string name):base(name)
	{

	}

	public override void takeDamage()
	{
		base.takeDamage();
		Debug.Log("Enemy hit taken");
	}

}


public class Player : Character
{
	public Player(string name) : base(name)
	{

	}

	public override void takeDamage()
	{ 
		Debug.Log("Player hit taken");

	}
	CharacterKilled killed = (Character killer, Character killed) =>
	{
		Debug.Log($"{killer.name} killed {killed.name}");
	};
}
