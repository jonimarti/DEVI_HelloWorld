using Player;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
	public class CreateCharacter : MonoBehaviour
	{

		// Use this for initialization
		void Start()
		{
			new Character(this.name);
		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}