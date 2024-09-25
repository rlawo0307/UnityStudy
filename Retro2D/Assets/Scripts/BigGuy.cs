using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BigGuy : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //PlayAttackAnimation();
            Die();
        }
    }

    private void PlayIdleAnimation()
    {
        this.animator.SetInteger("state", 0);
    }

    private void PlayAttackAnimation()
    {
        this.animator.SetInteger("state", 1);
        StartCoroutine(WaitForAnimation(1.000f));
    }

    private IEnumerator WaitForAnimation(float length)
    {
        yield return new WaitForSeconds(length);
        PlayIdleAnimation();
    }

    public void Impact()
    {
        Debug.Log("Impact");
        Debug.LogError("Impact"); // 콘솔창에서 error pause 검증할때 사용
    }

    private void Die()
    {
        animator.SetTrigger("Die");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);

        Collider2D[] contacts = new Collider2D[1];
        int length = collision.GetContacts(contacts);

        Debug.Log(length);
        Debug.Log(contacts[0]);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.contacts);
        Debug.Log(collision.contacts[0]);

        ContactPoint2D[] contacts = new ContactPoint2D[1];
        int length = collision.GetContacts(contacts);
        Debug.Log(length);
        Debug.Log(contacts[0]);
        Debug.Log(contacts[0].normal);
        DrawArrow.ForDebug(collision.transform.position, contacts[0].normal, 20, Color.yellow, ArrowType.Solid);
    }
}
