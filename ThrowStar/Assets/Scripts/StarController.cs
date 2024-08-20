using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class StarController : MonoBehaviour
{
    Vector3 startPosition;
    Vector3 endPosition;
    float moveSpeed;
    float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            endPosition = Input.mousePosition;
            if(endPosition.y - startPosition.y > 0)
            {
                moveSpeed = 0.2f;
                rotateSpeed = 10f;
            }
            else
            {
                moveSpeed = -0.2f;
                rotateSpeed = -10f;
            }
        }
        this.transform.Rotate(0, 0, rotateSpeed);
        this.transform.Translate(0, moveSpeed, 0, Space.World);

        moveSpeed *= 0.96f;
        rotateSpeed *= 0.96f;
    }
}
