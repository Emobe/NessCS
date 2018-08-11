using System;
using OpenTK.Input;
namespace NessCS
{
    public class InputManager
    {
        static KeyboardState keyboardState;
        static KeyboardState lastKeyboardState;

        public InputManager()
        {
            KeyboardState = Keyboard.GetState();
        }

        public void Update(double time)
        {
            LastKeyboardState = KeyboardState;
            KeyboardState = Keyboard.GetState();
        }

        public static bool KeyReleased(Key key)
        {
            return keyboardState.IsKeyUp(key) && lastKeyboardState.IsKeyDown(key);
        }

        public static bool KeyPressed(Key key)
        {
            return keyboardState.IsKeyDown(key) && lastKeyboardState.IsKeyUp(key);
        }

        public static bool KeyDown(Key key)
        {
            return keyboardState.IsKeyDown(key);
        }

        public static KeyboardState KeyboardState { get => keyboardState; set => keyboardState = value; }
        public static KeyboardState LastKeyboardState { get => lastKeyboardState; set => lastKeyboardState = value; }

    }
}
