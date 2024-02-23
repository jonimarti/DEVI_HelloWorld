using System.Collections;
using UnityEngine;


namespace PlayableCharacters
{
	


	public class Character
	{
		public enum Status
		{
			Regular,
			Stunned,
			Freezed
		}


		private Status status;
		private int kills;
		public string name;


		
		private int healthPoints = 1;
		[SerializeField]
		public delegate void CharacterKilled(Character killer, Character killed);
		public event CharacterKilled OnKilled;

		public Character(string name)
		{
			this.name = name;
			OnKilled += killed;
			Debug.Log("Hola, soy" + this.name);
		}
		~Character()
		{
			Debug.Log("Destroyed.");
		}

		public virtual void takeDamage() {
			if (healthPoints <= 0) healthPoints--;

		}
		protected virtual void TakeDamage(out bool diedFromMyAttack, ref Status attackingStatus)
		{
			healthPoints--;

			diedFromMyAttack = healthPoints <= 0;

			if (status == Status.Freezed)
			{
				attackingStatus = Status.Freezed;
			}
		}

		protected virtual (bool died, Status newStatus) TakeDamage(Status attackingStatus)
		{
			healthPoints--;

			bool died = healthPoints <= 0;
			Status newStatus = attackingStatus;

			if (status == Status.Freezed)
			{
				newStatus = Status.Freezed;
			}

			return (died, newStatus);
		}


		public void Hit(Character[] characters)
		{
			foreach (Character character in characters)
			{
				var result = character.TakeDamage(status);

				status = result.newStatus;

				if (result.died)
				{
					Debug.Log("And killed him!");

					//killedCallback(this, character);
				
					kills++;
					OnKilled(this, character);
				}
			}
		}

        private void killedCallback(Character character1, Character character2)
        {
            throw new System.NotImplementedException();
        }

		CharacterKilled killed = (Character killer, Character killed) =>
		{
			Debug.Log($"{killer.name} killed {killed.name}");
		};

	}


}
