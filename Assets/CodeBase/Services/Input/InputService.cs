using UnityEngine;

namespace Assets.CodeBase.Services.Input
{
    public abstract class InputService : IInputService
    {
        protected const string HORIZONTAL_AXIS = "Horizontal";
        protected const string VERTICAL_AXIS = "Vertical";
        protected const string FIRE_BUTTON = "Fire";

        public abstract Vector2 Axis { get; }

        public bool IsAttackButtonUp()
        => SimpleInput.GetButtonUp(FIRE_BUTTON);

        protected Vector2 JoystickAxis()
        => new(SimpleInput.GetAxis(HORIZONTAL_AXIS), SimpleInput.GetAxis(VERTICAL_AXIS));
    }
}