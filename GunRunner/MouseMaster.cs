using Microsoft.Xna.Framework.Input;

namespace GunRunner_v3
{
    static class MouseMaster
    {
        private static MouseState _formerState = new MouseState();
        public static bool IsLeftClicked()
        {
            return _formerState.LeftButton == ButtonState.Released & (_formerState = Mouse.GetState()).LeftButton == ButtonState.Pressed;
        }
        public static bool IsLeftReleased()
        {
            return _formerState.LeftButton == ButtonState.Pressed & (_formerState = Mouse.GetState()).LeftButton == ButtonState.Released;
        }
    }
}
