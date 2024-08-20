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
        //ť���� ��ġ�� ���
        //this�� CubeController class�� instance
        //this���� Transform�� Position�� �����Ϸ��� GameObject�� Cube�� ���� �����ؾ���
        Transform transform = this.gameObject.GetComponent<Transform>();
        //CubeController ������Ʈ�� �پ��ִ� GameObject�� Transform ������Ʈ�� position �Ӽ��� �� ���
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
