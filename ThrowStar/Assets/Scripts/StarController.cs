using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class StarController : MonoBehaviour
{
    Vector3 mouseDownPos;
    Vector3 mouseUpPos;
    float yDir;
    float moveSpeed;
    float rotateSpeed;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mouseDownPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            mouseUpPos = Input.mousePosition;

            yDir = mouseUpPos.y - mouseDownPos.y;
            
            moveSpeed = yDir * 0.001f;
            rotateSpeed = yDir * 0.1f;
        }

        //Mathf.Clamp() 사용해서 수정해보기
        if (this.transform.position.y < 4.5 && this.transform.position.y > -4.5)
        {
            this.transform.Rotate(0, 0, rotateSpeed);
            this.transform.Translate(0, moveSpeed, 0, Space.World);
        }

        moveSpeed *= 0.96f;
        rotateSpeed *= 0.96f;
    }
}
