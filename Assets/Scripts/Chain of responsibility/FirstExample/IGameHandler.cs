namespace Asteroids.ChainOfResponibility.FirstExample
{
    public interface IGameHandler
    {
        IGameHandler Handle();
        IGameHandler SetNext(IGameHandler nextHandler);
    }
}
