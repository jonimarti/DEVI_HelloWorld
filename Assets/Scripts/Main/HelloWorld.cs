using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game
{

    public class HelloWorld : MonoBehaviour
    {
        private Player player;
        private List<Enemy> enemies;

        void Start()
        {
            player = new Player("Pascual");
            player.OnKilled += OnKilled;

            enemies = new List<Enemy>();
            enemies.Add(new Enemy("Godofredo"));
            enemies.Add(new Enemy("Pepito"));
            enemies.Add(new Enemy("Godofredo 3"));
        }

        void Update()
        {
            // Linq. First: Obtener el primer elemento de la lisa que cumpla con la expresión
            var enemy = enemies.First(e => e.Name == "Pepito");
            Debug.Log("Encontrado! "+enemy);
            
            
            //   enemy.Hit(player, enemy);
            
        }

/*
 * Compilación condicional. El siguiente código sólo se evaluaría en dispositivos Android
 * https://docs.unity3d.com/Manual/PlatformDependentCompilation.html
 */
#if UNITY_ANDROID
        private void OnlyInAndroid()
        {
        //TODO: some stuff en android 
        }
#endif

        private void OnKilled(Character killer, Character killed)
        {
            Debug.Log($"{killer.Name} slain {killed.Name}.");
        }
    }

}