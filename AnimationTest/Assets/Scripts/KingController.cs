using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingController : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        
    }

    public void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); // -1, 0, 1
        
        if(h == 0f)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                animator.SetInteger("state", 2);
            }
            else
            {
                animator.SetInteger("state", 0);
            }
        }
        else
        {
            animator.SetInteger("state", 1);
            this.transform.localScale = new Vector3(h, 1, 1);
        }
    }
}
