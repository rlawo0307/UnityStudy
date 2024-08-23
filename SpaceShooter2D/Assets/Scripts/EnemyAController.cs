using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAController : MonoBehaviour
{
    public Animator animator;
    public bool isAttacked = false;

    string clipName;
    float remainTime;

    /*
    IEnumerator CoFade()
    {
        SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            Color color = new Color(1, 0, 0, alpha);
            sr.color = color;
            //yield return null; // ���� ���������� �Ѿ (null : ���� ������)
            yield return new WaitForSeconds(1f); // 1�� �� ���� ���������� �Ѿ
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(CoFade()); // �ڷ�ƾ ����

        if (remainTime > 0)
        {
            remainTime -= Time.deltaTime;
        }
        else
        {
            clipName = this.animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;

            if(clipName == "enemyA_hit")
            {
                GameObject.Destroy(this.gameObject);
            }

            if (isAttacked)
            {
                Debug.Log("aaa");
                animator.SetBool("isAttacked", true);
                remainTime = 0.700f;
            }
        }
    }
}
