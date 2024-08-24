using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject boomUIPrefab;
    public GameObject lifeUIPrefab;
    public Animator animator;

    GameObject[] lifeUIs;
    float moveSpeed = 3;
    int boomCount;
    int lifeCount = 3;

    // Start is called before the first frame update
    void Start()
    {
        lifeUIs = new GameObject[3];

        for(int i=0; i<3; i++)
        {
            lifeUIs[i] = Object.Instantiate(lifeUIPrefab);
            lifeUIs[i].transform.position = new Vector2(-2.4f + 0.6f * i, 4.6f);
            lifeUIs[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateBullet();
        }

        if(h == 0)
        {
            animator.SetInteger("state", 0);
        }
        else
        {
            if (h == -1)
            {
                animator.SetInteger("state", 1);
            }
            else if (h == 1)
            {
                animator.SetInteger("state", 2);
            }
        }

        //벡터의 정규화 (단위벡터)
        // 정규화 없이 사용하면 대각선으로 이동할때 속도가 살짝 더 빠름
        Vector3 dir = new Vector3(h, v, 0).normalized;

        //방향 * 속도 * 시간
        this.transform.Translate(dir * this.moveSpeed * Time.deltaTime); // 초당 이동할 위치
    }

    private void CreateBullet()
    {
        Vector3 shooterPos = this.transform.position;

        GameObject bulletGo = Object.Instantiate(bulletPrefab);
        bulletGo.transform.position = new Vector3(shooterPos.x, shooterPos.y + 0.6f, 0);
        bulletGo.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string collisionName = collision.gameObject.name;

        Debug.Log(collision.gameObject.name);
        if (collisionName == "Boom(Clone)")
        {
            Debug.Log("폭탄을 획득했습니다");
            GameObject boomUIGO = Object.Instantiate(boomUIPrefab);
            boomUIGO.transform.position = new Vector2(2.5f - 0.5f * this.boomCount, 4.7f);
            boomUIGO.SetActive(true);
            this.boomCount++;
            Debug.Log(this.boomCount);
            Object.Destroy(collision.gameObject);
        }
        else if (collisionName == "Coin(Clone)")
        {
            Debug.Log("코인을 획득했습니다");
            Object.Destroy(collision.gameObject);
        }
        else if(collisionName == "Power(Clone)")
        {
            Debug.Log("파워를 획득했습니다");
            Object.Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string collisionName = collision.gameObject.name;

        if (collisionName == "EnemyA(Clone)" || collisionName == "EnemyB(Clone)")
        {
            lifeCount--;
            Object.Destroy(lifeUIs[lifeCount]);

            if(lifeCount == 0)
            {
                Debug.Log("생명 없음");
                Object.Destroy(this.gameObject);
            }    
        }
    }
}
