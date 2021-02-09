using UnityEngine;


namespace Asteroids.ChainOfResponibility.SecondExample
{
    internal sealed class ChainOfResponibilityExample : MonoBehaviour
    {
        private void Start()
        {
            var asteroid = new Enemy("Asteroid", 1, 1);

            var root = new EnemyModifier(asteroid);
            root.Add(new AddAttackModifier(asteroid, 5));
            root.Add(new AddAttackModifier(asteroid, 10));
            root.Add(new AddDefenseModifier(asteroid, 100));
            root.Handle();
        }
    }
}
