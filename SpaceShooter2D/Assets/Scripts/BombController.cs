using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    float moveSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);

        if (this.transform.position.y <= -5.33f) // ȭ���� �Ѿ�� ����
        {
            Object.Destroy(this.gameObject);
        }
    }
}
