using gunrunner.try2;
using System.Collections.Generic;

namespace GunRunner_v3.States
{
    class MenuState //todo change to NVI
    {
        private List<Button> _buttons = new List<Button>();
        public void AddButton(Button button)
        {
            _buttons.Add(button);
        }

        public void AddButton(IEnumerable<Button> buttons)
        {
            _buttons.AddRange(buttons);
        }

        public void Update()
        {
            foreach (var button in _buttons)
            {
                if (button.IsClicked()) button.Behavior();
            }
        }

        public void Draw()
        {
            foreach (var button in _buttons) button.Draw();
        }

    }
}
