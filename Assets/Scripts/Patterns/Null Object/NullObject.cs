using System;
using UnityEngine;

namespace Asteroids.NullObject
{
    internal sealed class NullObject : MonoBehaviour
    {
        public event Action Doing = () => { };

        private void Start()
        {
            Doing.Invoke();
        }
    }
}
