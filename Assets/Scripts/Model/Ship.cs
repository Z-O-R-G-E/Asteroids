﻿using UnityEngine;

namespace Asteroids
{
    class Ship : IMove, IRotation
    {
        private readonly IMove _moveImplementation;
        private readonly IRotation _rotationImplementation;

        public float Speed 
        { 
            get 
            { 
                return _moveImplementation.Speed; 
            } 
        }

        public Ship(IMove moveImplementation, IRotation rotationImplementation)
        {
            _moveImplementation = moveImplementation;
            _rotationImplementation = rotationImplementation;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _moveImplementation.Move(horizontal, vertical, deltaTime);
        }

        public void AddAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.AddAcceleration();
            }
        }

        public void RemoveAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
            }
        }

        public void Rotation(Vector3 direction)
        {
            _rotationImplementation.Rotation(direction);
        }


    }
}
