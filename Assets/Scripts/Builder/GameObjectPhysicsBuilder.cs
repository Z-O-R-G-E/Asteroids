using UnityEngine;


namespace Asteroids.Builder
{
    internal sealed class GameObjectPhysicsBuilder : GameObjectBuilder
    {
        public GameObjectPhysicsBuilder(GameObject gameObject) : base(gameObject){}
        
        public GameObjectPhysicsBuilder PolygonCollider2D()
        {
            GetOrAddComponent<PolygonCollider2D>();
            return this;
        }

        public GameObjectPhysicsBuilder Camera(CameraClearFlags clearFlags, Color background, Vector3 position)
        {
            var component = GetOrAddComponent<Camera>();
            component.transform.position = position;
            component.clearFlags = clearFlags;
            component.backgroundColor = background;
            return this;
        }

        public GameObjectPhysicsBuilder AudioListener()
        {
            GetOrAddComponent<AudioListener>();
            return this;
        }

        public GameObjectPhysicsBuilder Rigidbody2D(float mass, bool isKinematic)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            component.isKinematic = isKinematic;
            return this;
        }

        private T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }
            return result;
        }
    }
}
