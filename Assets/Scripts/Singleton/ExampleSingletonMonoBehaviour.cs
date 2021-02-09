using UnityEngine;


namespace Asteroids.Singleton
{
    internal sealed class ExampleSingletonMonoBehaviour : SingletonMonoBehaviour<ExampleSingletonMonoBehaviour>
    {
        public void Test()
        {
            Debug.Log(nameof(ExampleSingletonMonoBehaviour));
        }
    }
}
