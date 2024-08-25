using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    float moveSpeed = 2;

    void Update()
    {
        this.transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);

        if (this.transform.position.y <= -5.33f) // ȭ���� �Ѿ�� ����
        {
            Object.Destroy(this.gameObject);
        }
    }
}
