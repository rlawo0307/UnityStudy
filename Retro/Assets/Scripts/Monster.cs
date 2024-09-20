using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] Animator animator;
    protected float attackAnimationLength;

    public System.Action onAttackComplete; // 1. 대리자 변수 정의

    public void Init(float time)
    {
        this.attackAnimationLength = time;
    }

    public void Idle()
    {
        animator.SetInteger("state", 0);
    }

    public void Run()
    {
        animator.SetInteger("state", 1);
    }

    public virtual void Attack()
    {
        animator.SetInteger("state", 2);
        Debug.Log(this.attackAnimationLength);
        StartCoroutine(CoWaitForAttackComplete());
    }

    IEnumerator CoWaitForAttackComplete()
    {
        /*
        float delta = 0;

        while(true)
        {
            delta += Time.deltaTime;
            if(delta >= this.attackAnimationLength)
            {
                break;
            }
            yield return null;
        }
        */
        yield return new WaitForSeconds(attackAnimationLength);
        onAttackComplete(); // 3. 대리자 호출
    }
}
