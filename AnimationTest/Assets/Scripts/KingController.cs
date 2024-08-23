using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class KingController : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb2D;
    public float moveForce;
    public float jumpForce;
    public int damage;
    public bool isAttack = false;

    string clipName;
    float remainTime;
    float h;

    public void Update()
    {
        clipName = this.animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;

        if (this.remainTime > 0)
        {
            this.remainTime -= Time.deltaTime;

            if (clipName == "king_attack" && isAttack)
            {
                isAttack = false;
            }
        }
        else
        {
            if (clipName == "king_attack")
            {
                Debug.Log("공격이 끝났습니다");
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                animator.SetInteger("state", 2);
                rb2D.velocity = new Vector2(0, 0);
                this.remainTime = 0.429f;
                isAttack = true;
            }
            else
            {
                h = Input.GetAxisRaw("Horizontal");

                if (h == 0f)
                {
                    animator.SetInteger("state", 0);
                }
                else
                {
                    animator.SetInteger("state", 1);
                    rb2D.velocity = new Vector2(h * moveForce, 0);
                    this.transform.localScale = new Vector3(h, 1, 1);
                }
            }
        }
    }
}
