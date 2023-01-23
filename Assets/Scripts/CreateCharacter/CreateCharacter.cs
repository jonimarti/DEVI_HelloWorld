using PlayableCharacters;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
	public class CreateCharacter : MonoBehaviour
	{
		Character[] EnemyCharacters = new Enemy[2];

		// Use this for initialization
		void Start()
		{

			for (int runs = 0; runs < 2; runs++)
			{
				EnemyCharacters[runs] = new Enemy("Character"+runs);
			}
		}

		// Update is called once per frame
		void Update()
		{
			Hit(EnemyCharacters);

		}

		public void Hit(Character[] characters)
		{
			foreach (Character character in characters)
			{
				Debug.Log("hit");
				character.takeDamage();
			}
		}

	}
}