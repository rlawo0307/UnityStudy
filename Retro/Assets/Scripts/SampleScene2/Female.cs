using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Female : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Vector3.forward);
        Debug.Log(this.transform.forward);

        DrawArrow.ForDebug(this.transform.position, Vector3.forward, 20, Color.blue);
        DrawArrow.ForDebug(this.transform.position, this.transform.forward, 20, Color.yellow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
