using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCGenerator : MonoBehaviour
{
    public GameObject enemyCPrefab;

    private float elapsedTime;  //����ð� 

    private void Update()
    {
        this.elapsedTime += Time.deltaTime;

        if (this.elapsedTime > 1f)
        {
            this.CreateEnemyC();
            this.elapsedTime = 0;
        }
    }

    private void CreateEnemyC()
    {
        GameObject enemyCGo = Object.Instantiate(enemyCPrefab);
        enemyCGo.transform.position = new Vector3(Random.Range(-2.5f, 2.5f), 4, 0);
        enemyCGo.SetActive(true);
    }
}
