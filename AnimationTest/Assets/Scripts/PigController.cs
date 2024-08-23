using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEditor.Search;
using UnityEngine;

public class PigController : MonoBehaviour
{
    public GameObject king;
    public Transform kingTrans;
    public Animator animator;
    public int hp;

    string clipName;
    float remainTime;
    bool isCollided;

    void Update()
    {
        clipName = this.animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;

        if (remainTime > 0)
        {
            remainTime -= Time.deltaTime;
        }
        else
        {
            if (clipName == "pig_dead")
            {
                Object.Destroy(this.gameObject);
            }
            else if (clipName == "pig_hit")
            {
                if (this.hp <= 0)
                {
                    animator.SetInteger("state", 2);
                    remainTime = 1.333f;
                    return;
                }
                else
                {
                    animator.SetInteger("state", 0);
                }
            }

            isCollided = this.CheckCollsion();

            if (isCollided)
            {
                this.hp -= king.GetComponent<KingController>().damage;
                animator.SetInteger("state", 1);
                this.remainTime = 0.286f;
            }
        }
    }

    private bool CheckCollsion()
    {
        float distance = kingTrans.position.x - this.transform.position.x;
        bool isAttack = king.GetComponent<KingController>().isAttack;

        if (-2.2f <= distance && distance <= 2.2f && isAttack)
        {
            return true;
        }
        else
            return false;
    }
}
