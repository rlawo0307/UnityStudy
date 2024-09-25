using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private bool isKeyDown = false;
    private bool isInit = false;

    public System.Action<Vector2> onKey;
    public System.Action onKeyUp;
    public System.Action onKeyDown;

    public void Init()
    {
        isInit = true;
    }

    void Update()
    {
        if(isInit)
        {
            var h = Input.GetAxisRaw("Horizontal");
            var v = Input.GetAxisRaw("Vertical");
            Vector3 dir = new Vector3(h, 0, v);

            if (dir != Vector3.zero)
            {
                if (!isKeyDown)
                {
                    Debug.Log("�̵� ����");
                }
                else
                {
                    Debug.Log("�̵� ��");
                }
                isKeyDown = true;
                this.transform.Translate(dir * 1 * Time.deltaTime);
            }
            else
            {
                if (isKeyDown)
                {
                    Debug.Log("�̵� ����");
                    isKeyDown = false;
                }
            }
        }
    }
}
