namespace Asteroids.Decorator
{
    internal abstract class ModificationWeapon : IFIre
    {
        private Weapon _weapon;
        protected abstract Weapon AddModification(Weapon weapon);

        public void ApplyModification(Weapon weapon)
        {
            _weapon = AddModification(weapon);
        }

        public void Fire()
        {
            _weapon.Fire();
        }
    }
}
