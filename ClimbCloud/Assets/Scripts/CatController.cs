using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public SpriteRenderer sr;
    public Animator animator;
    public float moveForce;
    public float jumpForce;

    void Start()
    {
        //rb2D = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽키 누름");
            this.rb2D.AddForce(new Vector2(-1 * moveForce, 0));
            this.transform.localScale = new Vector3(-1, 1, 1); // GameObject의 Scale을 바꾸는 거라서 하위 object까지 모두 좌우 반전 됨
            //sr.flipX = true;
            this.animator.SetInteger("state", 1);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽키 누름");
            this.rb2D.AddForce(new Vector2(1 * moveForce, 0));
            this.transform.localScale = new Vector3(1, 1, 1);
            //sr.flipX = false;
            this.animator.SetInteger("state", 1);
        }
        else if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("스페이스 키 누름");
            this.rb2D.AddForce(new Vector2(0, 1 * jumpForce));
        }
        else
        {
            this.animator.SetInteger("state", 0);
        }
    }
}
