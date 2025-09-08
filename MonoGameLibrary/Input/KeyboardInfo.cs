using Microsoft.Xna.Framework.Input;

namespace MonoGameLibrary.Input;

public class KeyboardInfo
{
    public KeyboardState PreviousState { get; private set; }
    public KeyboardState CurrentState { get; private set; }

    public KeyboardInfo()
    {
        PreviousState = new KeyboardState();
        CurrentState = Keyboard.GetState();
    }

    public void Update()
    {
        PreviousState = CurrentState;
        CurrentState = Keyboard.GetState();
    }


    public bool IsKeyDown(Keys key)
    {
        return CurrentState.IsKeyDown(key);
    }

    public bool IsKeyUp(Keys key)
    {
        return CurrentState.IsKeyUp(key);
    }

    public bool WasKeyJustPressed(Keys key)
    {
        return PreviousState.IsKeyUp(key) && CurrentState.IsKeyDown(key);
    }

    public bool WasKeyJustReleased(Keys key)
    {
        return PreviousState.IsKeyDown(key) && CurrentState.IsKeyUp(key);
    }
}

