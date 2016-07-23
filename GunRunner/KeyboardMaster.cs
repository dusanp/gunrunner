using Microsoft.Xna.Framework.Input;

namespace GunRunner_v2
{
    static class KeyboardMaster
    {
        private static KeyboardState _formerState = new KeyboardState();
        public static bool IsKeyPressed(Keys key)
        {
            return _formerState.IsKeyUp(key)&(_formerState=Keyboard.GetState()).IsKeyDown(key);
        }

        public static bool IsKeyReleased(Keys key)
        {
            return _formerState.IsKeyDown(key) & (_formerState = Keyboard.GetState()).IsKeyUp(key);
        }
    }
}
