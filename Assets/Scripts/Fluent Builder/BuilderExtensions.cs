using UnityEngine;

namespace Asteroids
{
    public static partial class BuilderExtensions
    {
        public static GameObject SetName(this GameObject gameObject, string name)
        {
            gameObject.name = name;
            return gameObject;
        }

        public static GameObject AddRigidbody2D(this GameObject gameObject, float mass)
        {
            var component = gameObject.GetOrAddComponetn<Rigidbody2D>();
            component.mass = mass;
            return gameObject;
        }

        public static GameObject AddBoxCollider2D(this GameObject gameObject)
        {
            gameObject.GetOrAddComponetn<BoxCollider2D>();
            return gameObject;
        }

        public static GameObject AddSprite(this GameObject gameObject, Sprite sprite)
        {
            var component = gameObject.GetOrAddComponetn<SpriteRenderer>();
            component.sprite = sprite;
            return gameObject;
        }

        private static T GetOrAddComponetn<T>(this GameObject gameObject) where T : Component
        {
            var result = gameObject.GetComponent<T>();
            if (!result)
            {
                result = gameObject.AddComponent<T>();
            }
            return result;
        }
    }
}
