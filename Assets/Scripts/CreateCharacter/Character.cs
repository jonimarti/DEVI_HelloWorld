using System.Collections;
using UnityEngine;


namespace Player
{
	
	public class Character
	{
		public string name;
		public Character(string name)
		{
			this.name = name;
			Debug.Log("Hola, soy" + name);
		}

	}


}
