using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    public Rigidbody2D rg2D;
    public float moveSpeed;

    /*
    void Start()
    {
        //StartCoroutine(CoMove());
    }
    */

    void Update()
    {
        this.transform.Translate(new Vector2(0, 1) * this.moveSpeed * Time.deltaTime);
        //rg2D.velocity = Vector2.up * moveSpeed;
        //Debug.Log(this.transform.position);
        //rg2D.velocity = Vector2.up * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<EnemyAController>().isAttacked = true;
        GameObject.Destroy(this.gameObject);
    }

    IEnumerator CoMove()
    {
        Debug.Log("aaa");
        while(true)
        {
            this.transform.Translate(Vector3.up * this.moveSpeed * Time.deltaTime);
            //rg2D.velocity = Vector2.up * moveSpeed;
            Debug.Log(this.transform.position);
            
            if(this.transform.position.y > 5.41f) // 화면을 넘어가면 제거
            {
                Object.Destroy(this.gameObject);
            }

            yield return null;
        }
    }
}
