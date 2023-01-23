using System.Collections;
using UnityEngine;


namespace PlayableCharacters
{
	
	public class Character
	{
		public string name;
		[SerializeField]
		private int healthPoints=10;
        public  Character(string name)
		{
			this.name = name;
			Debug.Log("Hola, soy" + this.name);
		}
		~Character()
		{
			Debug.Log("Destroyed.");
		}

		public virtual void takeDamage() {
			if (healthPoints <= 0) healthPoints--;

		}


	}


}
