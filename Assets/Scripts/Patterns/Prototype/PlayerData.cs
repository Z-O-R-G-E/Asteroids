using System;


namespace Asteroids.Prototype
{
    [Serializable]
    internal sealed class PlayerData
    {
        public float Speed;
        public HealthPoints Hp;

        public override string ToString()
        {
            return $"Speed {Speed} Hp {Hp}";
        }
    }
}
