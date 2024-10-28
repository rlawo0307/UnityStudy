using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventMain : MonoBehaviour
{
    UnityEvent m_MyEvent;

    void Start()
    {
        m_MyEvent = new UnityEvent();
        m_MyEvent.AddListener(() => {
            Debug.Log("이벤트를 받았습니다");
        });
    }

    void Update()
    {
        if (Input.anyKeyDown && m_MyEvent != null)
        {
            m_MyEvent.Invoke();
        }
    }
}
