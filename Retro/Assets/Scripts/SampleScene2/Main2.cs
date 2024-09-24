using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
    public Transform sphereTrans;
    public Transform cubeTrans;

    public GameObject someObject;
    public Vector3 thePosition;

    // Start is called before the first frame update
    void Start()
    {
        /*
        sphereTrans.position = new Vector3(0, -1, 0);
        sphereTrans.rotation = Quaternion.Euler(0, 0, 30);
        cubeTrans.localPosition = new Vector3(0, 2, 0);
        cubeTrans.localRotation = Quaternion.Euler(0, 60, 0);
        */

        thePosition = this.transform.TransformPoint(Vector3.left * 2);
        Instantiate(someObject, thePosition, someObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
