namespace Assets.CodeBase.Infrastructure
{
    public interface IState : IExitableState
    {
        public void Enter();
    }
}