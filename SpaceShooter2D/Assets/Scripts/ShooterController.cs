using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Animator animator;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
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

        //������ ����ȭ (��������)
        // ����ȭ ���� ����ϸ� �밢������ �̵��Ҷ� �ӵ��� ��¦ �� ����
        Vector3 dir = new Vector3(h, v, 0).normalized;

        //���� * �ӵ� * �ð�
        this.transform.Translate(dir * this.moveSpeed * Time.deltaTime); // �ʴ� �̵��� ��ġ
    }

    private void CreateBullet()
    {
        Vector3 shooterPos = this.transform.position;

        GameObject bulletGo = Object.Instantiate(bulletPrefab);
        bulletGo.transform.position = new Vector3(shooterPos.x, shooterPos.y + 0.6f, 0);
        bulletGo.SetActive(true);
    }
}
