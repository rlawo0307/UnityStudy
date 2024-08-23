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

    private void OnTriggerEnter2D(Collider2D collision) // �浹 ��� istrigger�� �������� ��
    {
        Debug.Log($"bbb : {collision}");
        //collision.gameObject.SetActive(false);

        SceneManager.LoadScene("GameOverScene"); // Build Settings�� Scenes in Build�� ��ϵǾ� �־�� ��
                                                 // 0��(�� ó�� ������ ��) �ε����� �����ϰ� ���� ��� ����
    }
}