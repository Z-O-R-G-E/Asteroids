using UnityEngine;


namespace Asteroids.ServiceLocator
{
    class Service : IService
    {
        public void Test()
        {
            Debug.Log(nameof(IService));
        }
    }
}
