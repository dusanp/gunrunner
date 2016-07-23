using GunRunner_v3;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace gunrunner.try2
{
    class Button
    {
        public Action Behavior
        {
            get; private set;
        }

        Texture2D Texture;
        Rectangle Position;
        string _text;

        public Button(Texture2D texture, Action behavior, Rectangle position, string text = "")
        {
            Behavior = behavior;
            Texture = texture;
            Position = position;
            _text = text;
        }

        public Button(Texture2D texture, Action behavior, Point position, string text = "")
            :this(texture, behavior, new Rectangle(position,new Point(texture.Width, texture.Height)), text) { }

        public Button(Texture2D texture, Action behavior, Vector2 position, string text = "")
            : this(texture, behavior, new Point((int)position.X, (int)position.Y), text) { }

        public bool IsClicked()
        {
            return Position.Contains(Mouse.GetState().Position)
                && MouseMaster.IsLeftClicked();
        }

        public void Draw()
        {
            GameMaster.Self.spriteBatch.Draw(Texture, Position, Color.White);
            TextMaster.Print(_text, Position.Center.ToVector2()); //todo center
        }
    }
}
