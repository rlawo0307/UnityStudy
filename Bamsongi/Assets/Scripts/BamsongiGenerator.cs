using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject BamsongiPrefab;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //GameObject bamsongiGo = Object.Instantiate(BamsongiPrefab);
            //bamsongiGo.GetComponent<BamsongiController>().Shoot();

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 100);

            Vector3 dir = ray.direction.normalized;
            GameObject bamsongiGo = Object.Instantiate(BamsongiPrefab);
            bamsongiGo.GetComponent<BamsongiController>().Shoot(dir * 2000);
        }
    }
}
