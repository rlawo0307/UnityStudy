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
        enemyAGo.transform.position = new Vector3(Random.Range(-1.25f, 1.25f), 3.77f, 0);
        enemyAGo.SetActive(true);
    }
}
