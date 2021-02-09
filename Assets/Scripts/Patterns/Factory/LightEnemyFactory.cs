using UnityEngine;


namespace Asteroids
{
    internal sealed class LightEnemyFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<LightEnemyShip>("Enemy/LightEnemyShip"));

            enemy.DependencyInjectHealth(hp);

            return enemy;
        }
    }
}
