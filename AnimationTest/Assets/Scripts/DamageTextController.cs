using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class DamageTextController : MonoBehaviour
{
    float remainTime = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(remainTime > 0)
        {
            remainTime -= Time.deltaTime;

            Vector2 startPos = this.transform.position;
            Vector2 endPos = new Vector2(startPos.x, startPos.y + 5);
            this.transform.position = Vector3.Lerp(startPos, endPos, remainTime);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
}
