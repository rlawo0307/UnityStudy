using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    public Rigidbody2D rg2D;
    
    float moveSpeed = 4;

    void Update()
    {
        this.transform.Translate(new Vector2(0, 1) * this.moveSpeed * Time.deltaTime);
    }

        IEnumerator CoMove()
    {
        Debug.Log("aaa");
        while(true)
        {
            this.transform.Translate(Vector3.up * this.moveSpeed * Time.deltaTime);
            //rg2D.velocity = Vector2.up * moveSpeed;
            Debug.Log(this.transform.position);
            
            if(this.transform.position.y > 5.41f) // ȭ���� �Ѿ�� ����
            {
                Object.Destroy(this.gameObject);
            }

            yield return null;
        }
    }
}
