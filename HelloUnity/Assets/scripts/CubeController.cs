using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Awake()
    {
          
    }

    // Start is called before the first frame update
    void Start()
    {
        //큐브의 위치를 출력
        //this는 CubeController class의 instance
        //this에서 Transform의 Position에 접근하려면 GameObject인 Cube에 먼저 접근해야함
        Transform transform = this.gameObject.GetComponent<Transform>();
        //CubeController 컴포넌트가 붙어있는 GameObject의 Transform 컴포넌트의 position 속성의 값 출력
        Debug.Log(transform.position);
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        Debug.Log(transform.position.z);

        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame


    void Update()
    {
        Debug.Log(this.transform.position);
        this.transform.position = new Vector3(0, 0, 1);
    }
}
