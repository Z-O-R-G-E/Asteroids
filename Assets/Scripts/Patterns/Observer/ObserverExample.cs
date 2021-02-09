﻿using UnityEngine;


namespace Asteroids.Observer
{
    class ObserverExample : MonoBehaviour
    {
        public Enemy Enemy;
        public float Damage;
        private Camera _mainCamera;
        private float _dedicateDistance = 20.0f;

        private void Start()
        {
            _mainCamera = Camera.main;
            var listenerHitShowDamage = new ListenerHitShowDamage();
            listenerHitShowDamage.Add(Enemy);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition),out var hit, _dedicateDistance))
                {
                    if(hit.collider.TryGetComponent<IHit>(out var enemy))
                    {
                        enemy.Hit(Damage);
                    }
                }
            }
        }
    }
}
