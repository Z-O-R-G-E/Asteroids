using System;


namespace Asteroids.Prototype
{
    [Serializable]
    internal sealed class HealthPoints
    {
        public float MaxHP;
        public float CurrentHP;

        public override string ToString()
        {
            return $"MaxHP {MaxHP} CurrentHP {CurrentHP}";
        }
    }
}
