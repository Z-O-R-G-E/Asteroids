using UnityEngine;


namespace Asteroids.Proxy.ProxyProtection
{
    internal sealed class Weapon : IWeapon
    {
        public void Fire()
        {
            Debug.Log("Fire");
        }
    }
}
