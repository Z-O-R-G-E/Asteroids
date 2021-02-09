namespace Asteroids
{
    interface IMove
    {
        float Speed { get; }
        void Move(float Horizontal, float vertical, float deltaTime);
    }
}