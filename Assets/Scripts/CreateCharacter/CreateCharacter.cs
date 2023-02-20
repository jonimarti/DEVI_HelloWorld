using PlayableCharacters;
using System;
using System.Collections;
using UnityEngine;
using static PlayableCharacters.Character;

namespace Assets.Scripts
{
	public class CreateCharacter : MonoBehaviour
	{
		const int MaxEnemies = 10;
		Character[] EnemyCharacters = new Enemy[MaxEnemies];
		Player player = new Player("test");
		
	
		void Start()
		{

			for (int runs = 0; runs < MaxEnemies; runs++)
			{
				Enemy enemy = new Enemy("Character" + runs);
				enemy.OnKilled += killed;
				EnemyCharacters[runs] = enemy;
				
			}

			player.Hit(EnemyCharacters);
		}


		CharacterKilled killed = (Character killer, Character killed) =>
		{
			Debug.Log("Im Dead");
		};

		// Update is called once per frame
		void Update()
		{
			

		}

		public void Hit(Character[] characters)
		{
			foreach (Character character in characters)
			{
				Debug.Log("hit");
				character.takeDamage();
			}
		}

		private void OnCharacterKilled(Character killer, Character killed)
		{
			Debug.Log($"{killer.name} killed {killed.name}");
		}

	}
}