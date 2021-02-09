using UnityEngine;

namespace Asteroids.Builder
{
    class GameObjectBuilding : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;

        private void Awake()
        {
            var gameObjectBuilder = new GameObjectBuilder();

            GameObject player = gameObjectBuilder
                .Visual.Name("Player").Sprite(_sprite)
                .Physics.Rigidbody2D(0, true).PolygonCollider2D();
        }
    }
}
