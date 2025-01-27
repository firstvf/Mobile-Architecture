using UnityEngine;

namespace Assets.CodeBase.Services.Input
{
    public interface IInputService
    {
        public Vector2 Axis { get; }
        public bool IsAttackButtonUp();
    }
}