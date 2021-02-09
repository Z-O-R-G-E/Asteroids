namespace Asteroids
{
    internal sealed class LightEnemyShip : Enemy
    {
        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }
    }
}