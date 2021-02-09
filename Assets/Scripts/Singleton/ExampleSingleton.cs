using UnityEngine;

namespace Asteroids.Singleton
{
    internal sealed class ExampleSingleton : MonoBehaviour
    {
        private void Statrt()
        {
            Services.Insance.Test();
        }
    }
}
