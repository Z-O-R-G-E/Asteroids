using UnityEngine;

namespace Asteroids
{
    public class AttackShip : IAttack
    {
        private Rigidbody2D _bullet;
        private Transform _barrel;
        private float _force;
        private float _damage;

        public float Damage { get; protected set; }

        public AttackShip(Rigidbody2D bullet, Transform barrel, float force, float damage)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
            Damage = damage;
        }

        public void Attack()
        {
            var temAmmunition = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }
    }
}