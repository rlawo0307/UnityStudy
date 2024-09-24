using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 60, 0)) * Quaternion.Euler(new Vector3(30, 0, 0));

        Debug.Log(this.transform.rotation);

        Debug.Log(this.transform.rotation.eulerAngles);
        */
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.transform.rotation *= Quaternion.Euler(new Vector3(10, 0, 0));
        }
    }
}
