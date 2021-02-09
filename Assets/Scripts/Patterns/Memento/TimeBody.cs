﻿using System.Collections.Generic;
using UnityEngine;


namespace Asteroids.Memento
{
    public sealed class TimeBody : MonoBehaviour
    {
        [SerializeField] private float _recordTime = 5.0f;
        private List<PointInTime> _pointsInTime;
        private Rigidbody _rigidbody;
        private bool _isRewinding;

        private void Start()
        {
            _pointsInTime = new List<PointInTime>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                StartRewind();
            }
            if (Input.GetKeyUp(KeyCode.Q))
            {
                StopRewind();
            }
        }

        private void FixedUpdate()
        {
            if (_isRewinding)
            {
                Rewind();
            }
            else
            {
                Record();
            }
        }

        private void Rewind()
        {
            if(_pointsInTime.Count > 1)
            {
                PointInTime pointInTime = _pointsInTime[0];
                transform.position = pointInTime.Position;
                transform.rotation = pointInTime.Rotation;
                _pointsInTime.RemoveAt(0);
            }
            else
            {
                PointInTime pointInTime = _pointsInTime[0];
                transform.position = pointInTime.Position;
                transform.rotation = pointInTime.Rotation;
                StopRewind();
            }
        }

        private void Record()
        {
            if(_pointsInTime.Count > Mathf.Round(_recordTime / Time.fixedDeltaTime))
            {
                _pointsInTime.Insert(0, new PointInTime(transform.position, _rigidbody.velocity, _rigidbody.angularVelocity, transform.rotation));
            }
        }

        private void StartRewind()
        {
            _isRewinding = true;
            _rigidbody.isKinematic = true;
        }

        private void StopRewind()
        {
            _isRewinding = false;
            _rigidbody.isKinematic = false;
            _rigidbody.velocity = _pointsInTime[0].Velocity;
            _rigidbody.angularVelocity = _pointsInTime[0].AngularVelocity;
        }
    }
}
