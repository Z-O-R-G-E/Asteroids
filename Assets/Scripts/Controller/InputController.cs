using UnityEngine;


namespace Asteroids
{
    class InputController : IExecute
    {

        private readonly Ship _ship;
        private readonly Camera _camera;
        private readonly Transform _transform;

        public InputController(Ship player, Transform transform, Camera camera)
        {
            _ship = player;
            _transform = transform;
            _camera = camera;
        }

        public void Execute()
        {
            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();

            }

            var direction = Input.mousePosition - _camera.WorldToScreenPoint(_transform.position);
            _ship.Rotation(direction);

        }
    }
}
