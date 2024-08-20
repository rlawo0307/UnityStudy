using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class RouletteController : MonoBehaviour
{
    float rotationSpeed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotationSpeed = 10;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rotationSpeed = -10;
        }
        this.transform.Rotate(0, 0, rotationSpeed); // ���� �پ��ִ� gameObject�� Transform ������Ʈ�� Rotate �Լ� ȣ��
        rotationSpeed *= 0.96f;
        Debug.Log(rotationSpeed);
    }
}
