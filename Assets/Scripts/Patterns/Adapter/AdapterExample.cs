using UnityEngine;


namespace Asteroids.Adapter
{
    internal sealed class AdapterExample : MonoBehaviour
    {
        private Camera _camera;
        private IFire _fire;

        private void Awake()
        {
            _camera = Camera.main;
            _fire = new Enemy();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var mousePos = Input.mousePosition;
                mousePos.z = 20.0f;
                var objectPos = _camera.ScreenToViewportPoint(mousePos);

                _fire.Fire(objectPos);
            }
        }
    }
}
