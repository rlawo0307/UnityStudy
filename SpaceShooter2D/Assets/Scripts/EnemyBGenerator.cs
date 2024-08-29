using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBGenerator : MonoBehaviour
{
    public GameObject enemyBPrefab;

    private float elapsedTime;  //경과시간 

    private void Update()
    {
        this.elapsedTime += Time.deltaTime;

        if (this.elapsedTime > 1f)
        {
            //this.CreateEnemyB();
            this.elapsedTime = 0;
        }
    }

    private void CreateEnemyB()
    {
        GameObject enemyBGo = Object.Instantiate(enemyBPrefab);
        enemyBGo.transform.position = new Vector3(Random.Range(-1f, 1f), 3.5f, 0);
        enemyBGo.SetActive(true);
    }
}
