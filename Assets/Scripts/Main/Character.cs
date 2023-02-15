using UnityEngine;

namespace Juego
{

    public enum Status
    {
        None,
        Stunned,
        Frozen
    }

    /*
     * Delegate: un tipo usado para almacenar referencias a métodos.
     * En el delegate se describe la firma del método. En este caso: valor de retorno void, dos parámetros Character
     */
    public delegate void CharacterKilledHandled(Character killer, Character killed);

    public abstract class Character 
    {

        /*
         * Un evento que se puede llamar desde esta clase y notificar a los suscriptores del evento (0, 1 o varios)
         */
        public event CharacterKilledHandled OnKilled;
        private int kills;
        private Status status;

        public const int InitialHealthPoints = 10;
        private int healthPoints = InitialHealthPoints;

        // Propiedad autoimplementada (lectura pública, escritura privada)
        public string Name { get; private set; }

        // Constructor
        public Character(string name)
        {
            Name = name;

            Debug.Log($"Hola, soy {name}.");
        }

        // Con params podemos definir parámetros de longitud variable
        public void Hit(params Character[] characters)
        {
            foreach (Character character in characters)
            {
                var result = character.TakeDamage(status);

                if (result.died)
                {
                    kills++;

                    Debug.Log($"{Name} killed {character.Name}");

                    if (OnKilled != null)
                    {
                        OnKilled.Invoke(this, character);
                    }
                }
                status = result.attackingStatus;
            }
        }

        /*
         * Ejemplo de una tupla en el valor de retorno (secuencia de parámetros)
         * El método está marcado como "virtual" para poder hacer "override" del mismo
         */
        public virtual (bool died, Status attackingStatus) TakeDamage(Status previousStatus)
        {
            healthPoints--;

            bool died = healthPoints <= 0;

            Status attackingStatus = previousStatus;
            if (status == Status.Frozen )
            {
                attackingStatus = Status.Frozen;
            }

            return (died, attackingStatus);
        }

        // Destructor
        ~Character()
        {
            Debug.Log("Destroyed");
        }

    }

    // Herencia de Character
    class Player : Character
    {
        public Player(string name) : base(name)
        {
        }

        // "Override" del método TakeDamage
        public override (bool died, Status attackingStatus) TakeDamage(Status previousStatus)
        {
            return base.TakeDamage(previousStatus);
        }
    }

    // Herencia de Character
    class Enemy : Character
    {
        public Enemy(string name) : base(name)
        {
        }
    }
}
