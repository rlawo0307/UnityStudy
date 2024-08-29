using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCGenerator : MonoBehaviour
{
    public GameObject enemyCPrefab;

    private float elapsedTime;  //경과시간 

    private void Update()
    {
        this.elapsedTime += Time.deltaTime;

        if (this.elapsedTime > 1f)
        {
            //this.CreateEnemyC();
            this.elapsedTime = 0;
        }
    }

    private void CreateEnemyC()
    {
        GameObject enemyCGo = Object.Instantiate(enemyCPrefab);
        enemyCGo.transform.position = new Vector3(Random.Range(-0.8f, 0.8f), 3.435f, 0);
        enemyCGo.SetActive(true);
    }
}
