using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAGenerator : MonoBehaviour
{
    public GameObject enemyAPrefab;

    private float elapsedTime;  //경과시간 

    private void Update()
    {
        this.elapsedTime += Time.deltaTime;

        if (this.elapsedTime > 1f)
        {
            this.CreateEnemyA();
            this.elapsedTime = 0;
        }
    }

    private void CreateEnemyA()
    {
        GameObject enemyAGo = Object.Instantiate(enemyAPrefab);
        enemyAGo.transform.position = new Vector3(Random.Range(-2.5f, 2.5f), 4, 0);
        enemyAGo.SetActive(true);
    }
}
