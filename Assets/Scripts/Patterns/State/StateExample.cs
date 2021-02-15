using UnityEngine;


namespace Asteroids.State
{
    public sealed class StateExample : MonoBehaviour
    {
        private void Start()
        {
            Context context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}
