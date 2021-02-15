using UnityEngine;


namespace Asteroids.Strategy
{
    public sealed class StrategyExample : MonoBehaviour
    {
        [SerializeField] private BaseBehaviour _behaviour;

        private void Update()
        {
            _behaviour.Behaviour(transform);
        }
    }
}