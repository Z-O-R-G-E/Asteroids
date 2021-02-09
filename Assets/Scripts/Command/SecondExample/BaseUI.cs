using UnityEngine;

namespace Asteroids.Command.SecondExample
{
    internal abstract class BaseUI : MonoBehaviour
    {
        public abstract void Execute();
        public abstract void Cancel();
    }
}
