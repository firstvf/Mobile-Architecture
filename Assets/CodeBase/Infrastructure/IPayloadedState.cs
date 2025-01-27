﻿namespace Assets.CodeBase.Infrastructure
{
    public interface IPayloadedState<TPayload> : IExitableState
    {
        public void Enter(TPayload payload);
    }
}