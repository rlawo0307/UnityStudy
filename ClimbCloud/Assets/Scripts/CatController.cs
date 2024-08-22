using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float moveForce;
    public float jumpForce;

    void Start()
    {
        //rb2D = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽키 누름");
            this.rb2D.AddForce(new Vector2(-1 * moveForce, 0));
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽키 누름");
            this.rb2D.AddForce(new Vector2(1 * moveForce, 0));
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("스페이스 키 누름");
            this.rb2D.AddForce(new Vector2(0, 1 * jumpForce));
        }
    }
}
