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
        this.transform.Rotate(0, 0, rotationSpeed); // 내가 붙어있는 gameObject의 Transform 컴포넌트에 Rotate 함수 호출
        rotationSpeed *= 0.96f;
        Debug.Log(rotationSpeed);
    }
}
