using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBController : MonoBehaviour
{
    public GameObject boomPrefab;
    public GameObject coinPrefab;
    public GameObject powerPrefab;
    public Animator animator;

    string clipName;
    float remainTime;
    float moveSpeed = 1.5f;
    bool isAttacked = false;

    void Update()
    {
        this.transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);

        if (remainTime > 0)
        {
            remainTime -= Time.deltaTime;
        }
        else
        {
            clipName = this.animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;

            if (clipName == "enemyB_hit")
            {
                Vector3 enemeyBPos = this.transform.position;

                float rate = Random.Range(1, 11); // 1~10 사이의 랜덤 수 추출
                if (rate <= 10) // 20% 확률로
                {
                    float itemType = Random.Range(0, 3);
                    GameObject itemGo;

                    switch (itemType)
                    {
                        case 0: itemGo = Object.Instantiate(boomPrefab); break;
                        case 1: itemGo = Object.Instantiate(coinPrefab); break;
                        default: itemGo = Object.Instantiate(powerPrefab); break; // case 2
                    }
                    itemGo.transform.position = new Vector3(enemeyBPos.x, enemeyBPos.y, 0);
                    itemGo.SetActive(true);
                }
                GameObject.Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isAttacked)
        {
            if (collision.gameObject.name == "PlayerBullet(Clone)")
            {
                isAttacked = true;
                animator.SetBool("isAttacked", true);
                remainTime = 0.700f;
                GameObject.Destroy(collision.gameObject);
            }
        }
    }
}
