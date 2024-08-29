using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoomController : MonoBehaviour
{ 
    public Animator animator;

    float remainTime;

    private void Start()
    {
        remainTime = 0.3f;
        animator.SetBool("state", true);
    }

    private void Update()
    {
        if(remainTime > 0)
        {
            remainTime -= Time.deltaTime;
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "EnemyA(Clone)")
        {
            Object.Destroy(col.gameObject);
        }
    }
}
