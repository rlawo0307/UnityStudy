using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bombUIPrefab;
    public GameObject boomPrefab;
    public GameObject lifeUIPrefab;
    public Animator animator;

    GameObject[] lifeUIs;
    float moveSpeed = 3;
    int bombCount;
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
        else if(Input.GetKeyDown(KeyCode.B))
        {
            GameObject boomGo = Object.Instantiate(boomPrefab);
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

        if (collisionName == "Bomb(Clone)")
        {
            GameObject bombUIGO = Object.Instantiate(bombUIPrefab);
            bombUIGO.transform.position = new Vector2(2.5f - 0.5f * this.bombCount, 4.7f);
            bombUIGO.SetActive(true);
            this.bombCount++;
            Object.Destroy(collision.gameObject);
        }
        else if (collisionName == "Coin(Clone)")
        {
            Object.Destroy(collision.gameObject);
        }
        else if(collisionName == "Power(Clone)")
        {
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
                Object.Destroy(this.gameObject);
            }    
        }
    }
}
