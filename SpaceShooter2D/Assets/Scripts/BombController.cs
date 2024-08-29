using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    float moveSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);

        if (this.transform.position.y <= -5.33f) // 화면을 넘어가면 제거
        {
            Object.Destroy(this.gameObject);
        }
    }
}
