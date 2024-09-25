using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class LerpMain : MonoBehaviour
{
    public Transform woman;
    public Transform startPoint;
    public Transform endPoint;
    public Transform endPoint2;
    public float duration = 2f;

    private float elapsedTime;
    private float t = 0;

    void Start()
    {
        /*
        this.woman.transform
            .DOMove(endPoint.position, 2f)
            .SetEase(Ease.OutQuad)
            .OnComplete(() => {
                Debug.Log("move Complete");
            });

        this.woman.transform
            .DORotate(new Vector3(0, 90, 0), 2f)
            .SetEase(Ease.OutQuad)
            .OnComplete(() => {
                Debug.Log("rotate Complete");
            });
        */
    }

    /*
    void Update()
    {
        if(t < 1)
        {
            elapsedTime += Time.deltaTime;
            t = elapsedTime / duration;
            Vector3 pos = Vector3.Slerp(startPoint.position, endPoint.position, t);
            woman.position = pos;
            Debug.Log(t);
            Debug.Log("move exit");
        }
    }
    */
}
