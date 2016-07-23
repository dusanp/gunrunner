using Microsoft.Xna.Framework;

namespace GunRunner_v3
{
    static class RectangleExtensions
    {
        static bool Contains(this Rectangle rectangle, Point point)
        {
            return point.X > rectangle.Left
                && point.X < rectangle.Right
                && point.Y > rectangle.Top
                && point.Y < rectangle.Bottom;
        }

        static Vector2 ToVector2(this Point point)
        {
            return new Vector2(point.X, point.Y);
        }
    }
}
