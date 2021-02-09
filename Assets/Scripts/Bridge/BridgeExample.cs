using UnityEngine;


namespace Asteroids.Bridge
{
    internal sealed class BridgeExample : MonoBehaviour
    {
        private void Start()
        {
            var enemy = new Enemy(new MagicalAttack(), new Infantry());
        }
    }
}
