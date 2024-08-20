using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    //������ ���� ����
    public GameObject A;
    public GameObject B;

    Vector3 mouseDownPos;
    Vector3 mouseUpPos;

    void Start()
    {
        Vector3 a = A.transform.position; // ��ġ����
        Vector3 b = B.transform.position; // ��ġ����
        Vector3 c = b - a; // ���⺤��

        DrawArrow.ForDebug(a, c, 5, Color.yellow, ArrowType.Solid); // 5�� ������ �ð�
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
            Debug.Log($"{xDir}"); // ��Į�� ���� ����, ����/��� �� ������ �ǹ�

            if (xDir > 0)
            {
                Debug.Log("������");
            }
            else if (xDir < 0)
            {
                Debug.Log("����");
            }
        }

    }
}
