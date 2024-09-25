using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1Main : MonoBehaviour
{
    public enum InputType
    {
        Joystick,
        Keyboard
    }

    public FixedJoystick joyStick;
    public InputManager keyboardInputManager;

    public InputType inputType;
    public Player player;

    void Start()
    {
        if(inputType == InputType.Joystick)
        {

        }
        else
        {
            keyboardInputManager.onKeyDown = () => {
                Debug.Log("Down");
            };

            keyboardInputManager.onKeyUp = () => {
                Debug.Log("Up");
            };

            keyboardInputManager.onKey = (direction) => {
                Debug.Log(direction);
            };
        }
    }

    void Update()
    {
        
    }
}
