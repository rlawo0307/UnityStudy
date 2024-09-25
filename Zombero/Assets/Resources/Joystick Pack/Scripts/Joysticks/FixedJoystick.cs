using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedJoystick : Joystick
{
    private bool isKeyDown = false;

    public System.Action<Vector2> onKey;
    public System.Action onKeyUp;
    public System.Action onKeyDown;

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        if (!isKeyDown)
        {
            Debug.Log("이동 시작");
        }
        else
        {
            Debug.Log("이동 중");
        }
        isKeyDown = true;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        if (isKeyDown)
        {
            Debug.Log("이동 멈춤");
            isKeyDown = false;
        }
    }

    private void Update()
    {
        if (Direction != Vector2.zero)
        {
            if (isKeyDown)
            {
                Debug.Log("이동 중");
            }
        }
    }
}