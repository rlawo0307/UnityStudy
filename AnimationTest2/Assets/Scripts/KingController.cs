using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KingController : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb2D;
    public float moveSpeed = 1f;

    void Update()
    {
        //-1, 0, 1
        float h = Input.GetAxisRaw("Horizontal");
        if (h == 0)
        {
            animator.SetInteger("State", 0);   //Idle
        }
        else
        {
            //-1, 1
            animator.SetInteger("State", 1);    //Run
            this.transform.localScale = new Vector3(h, 1, 1);

            this.rb2D.velocity = new Vector2(h * moveSpeed, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"aaa : {collision}");
    }

    private void OnTriggerEnter2D(Collider2D collision) // 충돌 대상에 istrigger가 켜져있을 때
    {
        Debug.Log($"bbb : {collision}");
        //collision.gameObject.SetActive(false);

        SceneManager.LoadScene("GameOverScene"); // Build Settings에 Scenes in Build에 등록되어 있어야 함
                                                 // 0번(맨 처음 시작할 씬) 인덱스를 제외하고 순서 상관 없음
    }
}