using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    //벡터의 뺄셈 연습
    public GameObject A;
    public GameObject B;

    Vector3 mouseDownPos;
    Vector3 mouseUpPos;

    void Start()
    {
        Vector3 a = A.transform.position; // 위치벡터
        Vector3 b = B.transform.position; // 위치벡터
        Vector3 c = b - a; // 방향벡터

        DrawArrow.ForDebug(a, c, 5, Color.yellow, ArrowType.Solid); // 5는 보여줄 시간
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseDownPos = Input.mousePosition;
            Debug.Log($"DownPos : {mouseDownPos}");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            mouseUpPos = Input.mousePosition;
            Debug.Log($"UpPos : {mouseUpPos}");

            float xDir = mouseUpPos.x - mouseDownPos.x;
            Debug.Log($"{xDir}"); // 스칼라 값은 길이, 음수/양수 는 방향을 의미

            if (xDir > 0)
            {
                Debug.Log("오른쪽");
            }
            else if (xDir < 0)
            {
                Debug.Log("왼쪽");
            }
        }

    }
}
