using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector3 startPosition;
    Vector3 endPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            endPosition = Input.mousePosition;

            if(endPosition.x - startPosition.x > 0)
            {
                speed = 0.2f;
            }
            else
            {
                speed = -0.2f;
            }
        }
        this.transform.Translate(speed, 0, 0);
        speed *= 0.96f;
    }
}
