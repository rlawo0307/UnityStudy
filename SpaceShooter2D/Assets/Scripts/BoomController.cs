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
        Debug.Log(remainTime);
    }

    private void Update()
    {
        Debug.Log(remainTime);
        if(remainTime > 0)
        {
            remainTime -= Time.deltaTime;
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
