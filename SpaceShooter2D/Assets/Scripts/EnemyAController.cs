using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAController : MonoBehaviour
{
    public GameObject bombPrefab;
    public GameObject coinPrefab;
    public GameObject powerPrefab;
    public Animator animator;

    string clipName;
    float remainTime;
    float moveSpeed = 1.5f;
    bool isAttacked = false;
    int score = 10;

    /*
    IEnumerator CoFade()
    {
        SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            Color color = new Color(1, 0, 0, alpha);
            sr.color = color;
            //yield return null; // 다음 프레임으로 넘어감 (null : 다음 프레임)
            yield return new WaitForSeconds(1f); // 1초 후 다음 프레임으로 넘어감
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(CoFade()); // 코루틴 수행

        this.transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);

        if (remainTime > 0)
        {
            remainTime -= Time.deltaTime;
        }
        else
        {
            clipName = this.animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;

            if(clipName == "enemyA_hit")
            {
                Vector3 enemeyAPos = this.transform.position;

                float rate = Random.Range(1, 11); // 1~10 사이의 랜덤 수 추출
                if (rate <= 10) // 20% 확률로
                {
                    float itemType = Random.Range(0, 3);
                    GameObject itemGo;

                    switch(itemType)
                    {
                        case 0: itemGo = Object.Instantiate(bombPrefab); break;
                        case 1: itemGo = Object.Instantiate(coinPrefab); break;
                        default: itemGo = Object.Instantiate(powerPrefab); break; // case 2
                    }
                    itemGo.transform.position = new Vector3(enemeyAPos.x, enemeyAPos.y, 0);
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
                /*
                Text scoreText = GameObject.Find("Score").GetComponent<Text>();
                int newScore = int.Parse(scoreText.text) + this.score;
                scoreText.text = newScore.ToString();
                */

                isAttacked = true;
                animator.SetBool("isAttacked", true);
                remainTime = 0.700f;
                GameObject.Destroy(collision.gameObject);
            }
        }
    }
}
