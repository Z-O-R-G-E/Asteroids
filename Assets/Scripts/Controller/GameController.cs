using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public sealed class GameController : MonoBehaviour, IDisposable
    {
        private List<IExecute> _interactiveObject;
        private CameraController _cameraController;
        private InputController _inputController;
        private Transform _playerTransform;
        private Camera _mainCamera;
        private Ship _player;

        private void Start()
        {
            _interactiveObject = new List<IExecute>();

            _playerTransform = GameObject.FindWithTag("Player").transform;
            _mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();

            var moveTransform = new AccelerationMove(_playerTransform, 3, 5);
            var rotation = new RotationShip(_playerTransform);
            _player = new Ship(moveTransform, rotation);

            _cameraController = new CameraController(_playerTransform, _mainCamera.transform);
            _interactiveObject.Add(_cameraController);

            _inputController = new InputController(_player, _playerTransform, _mainCamera);
          _interactiveObject.Add(_inputController);
            
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObject.Count; i++)
            {
                var interactiveObject = _interactiveObject[i];

                if (interactiveObject == null)
                {
                    continue;
                }
                interactiveObject.Execute();
            }
        }

        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            {
                
            }
        }
    }
}
