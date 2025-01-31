﻿using Assets.CodeBase.Infrastructure;
using Assets.CodeBase.Services.Input;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public static IInputService InputService;
        public readonly GameStateMachine StateMachine;

        public Game(ICoroutineRunner coroutineRunner)
        {
            StateMachine = new GameStateMachine(new SceneLoader(coroutineRunner));
        }        
    }
}