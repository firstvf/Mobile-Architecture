using UnityEngine;

namespace Assets.CodeBase.Services.Input
{
    public class StandaloneInputService : InputService
    {
        public override Vector2 Axis
        {
            get
            {
                Vector2 axis = JoystickAxis();

                if (axis == Vector2.zero)
                    axis = UnityAxis();

                return axis;
            }
        }

        private Vector2 UnityAxis()
        => new Vector2(UnityEngine.Input.GetAxis(HORIZONTAL_AXIS), UnityEngine.Input.GetAxis(VERTICAL_AXIS));
    }
}