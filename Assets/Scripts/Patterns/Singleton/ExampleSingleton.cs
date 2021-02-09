using UnityEngine;

namespace Asteroids.Singleton
{
    internal sealed class ExampleSingleton : MonoBehaviour
    {
        private void Start()
        {
            Services.Insance.Test();
        }
    }
}
