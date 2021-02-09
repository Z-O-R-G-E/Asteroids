using UnityEngine;


namespace Asteroids.Memento
{
    public sealed class PointInTime
    {
        public Vector3 Position;
        public Vector3 Velocity;
        public Vector3 AngularVelocity;
        public Quaternion Rotation;

        public PointInTime(Vector3 position, Vector3 velocity, Vector3 angularVelocity, Quaternion rotation)
        {
            Position = position;
            Velocity = velocity;
            AngularVelocity = angularVelocity;
            Rotation = rotation;
        }
    }
}
