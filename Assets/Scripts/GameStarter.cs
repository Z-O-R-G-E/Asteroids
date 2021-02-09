using System;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.AbstractFactory;
using Asteroids.Enemy_Pool;
using Asteroids.Builder;


namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;

        private GameObjectBuilder _gameObjectBuilder;
        private GameObject _player;
        private GameObject _camera;
        private GameObject _particalStars;
        private LightEnemyFactory _lightEnemyFactory;


        private void Awake()
        {
            _gameObjectBuilder = new GameObjectBuilder();
            _camera = _gameObjectBuilder
                .Visual.Name("Main camera").Tag("MainCamera")
                .Physics.Camera(CameraClearFlags.SolidColor, Color.black, new Vector3(0.0f, 0.0f, -10.0f)).AudioListener();

            _gameObjectBuilder = new GameObjectBuilder();
            _player = _gameObjectBuilder
                .Visual.Name("Player").Tag("Player").Sprite(_sprite)
                .Physics.Rigidbody2D(0, true).PolygonCollider2D();

            GameObject turret = new GameObject("Turret");
            turret.transform.SetParent(_player.transform, false);
            turret.transform.position = new Vector3(0.0f, 0.6f, 0.0f);

            _particalStars = Instantiate(Resources.Load("Dust Particles/Prefab/Dust Particles") as GameObject);
            _particalStars.transform.SetParent(_camera.transform, false);

            Enemy.CreateAsteroidEnemyWithPool(new EnemyPool(5), new Health(100.0f, 100.0f));

            _lightEnemyFactory = new LightEnemyFactory();
            _lightEnemyFactory.Create(new Health(100.0f,100.0f));

            var platform = new PlatformFactory().Create(Application.platform);
        }
    }
}