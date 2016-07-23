using gunrunner.try2;
using Microsoft.Xna.Framework;

namespace GunRunner_v3
{
    static class TextMaster
    {
        public static void Print(string text, Vector2 position)
        {
            GameMaster.Self.spriteBatch.DrawString(GameMaster.Self.CourierNew, text, position ,Color.Black);
        }
    }
}
